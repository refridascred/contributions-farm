using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 0.37;
        public const long StepRatio = 5916;
        public const long BurstRoute = 6469;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ (step - score)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next filter report value from a seed.</summary>
        public static long IterateFilterReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((result & 127) > (long)i)
                {
                    result = (result + (result % 2)) % 97;
                    result = ((result << 2) ^ (result & 1)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
