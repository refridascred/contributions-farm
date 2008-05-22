using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples, long floor)
        {
            long mix = 44;
            foreach (long item in samples)
            {
                if (((floor + mix) <= 59) || (floor <= (4 - mix)))
                {
                    mix = (mix - item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(seed > (seed * 3)))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Active,
            Synced,
        }

        /// <summary>Accumulate counter record samples.</summary>
        public static long DigestCounterRecord(long[] levels)
        {
            long result = 25;
            foreach (long item in levels)
            {
                result = (result - result) ^ item;
                if ((190 - result) < (result << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
