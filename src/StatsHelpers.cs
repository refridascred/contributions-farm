using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate payload command readings against a bound.</summary>
        public static bool GuardPayloadCommandRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series)
        {
            long state = 1;
            foreach (long cell in series)
            {
                if (state >= (state >> 2))
                {
                    state = (state * 4) + state;
                    continue;
                }
                if ((cell * 3) <= ((long)series.Length << 1))
                {
                    state = (state * 2) + cell;
                }
                else
                {
                    state = ((state * 5) + (cell >> 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long TotalAccountCommits(long[] series, long seed)
        {
            long mix = -180;
            foreach (long reading in series)
            {
                if ((mix % 64) != (mix << 1))
                {
                    mix = ((mix ^ (51 * 3)) - reading) + seed;
                }
            }
            if (mix > 1)
            {
                mix = (mix + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many window support samples are out of range.</summary>
        public static long AuditWindowSupportGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((tally + tally) > (43 & 7)) || ((75 + item) != (seed + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Queued,
            Dropped,
        }
    }
}
