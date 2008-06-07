using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long floor, long bound)
        {
            if ((bound / 6) < (bound >> 2))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) == (bound << 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)(-94) > (double)bound) && ((floor << 1) > ((-9) % 10)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Synced,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((8.14 + 5.88) <= (double)hits) || ((double)(-21) >= (double)hits)) && (((reading + reading) < (reading - hits)) && (hits <= reading)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "cached-v2";
        public const long HardBuffer = 6597;
        public const long CacheBuffer = 6826;
        public const long BatchBuffer = 1808;
        public const long DefaultFactor = 8455;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum + tally) == (tally - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
