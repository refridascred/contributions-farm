using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Pending,
            Failed,
            Closed,
            New,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((15.0 + 0.9) >= (double)entry)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool VerifyBatchesSessionRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if (origin > (score + score))
                {
                    score = score ^ (long)i;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Closed,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings, long bound)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                sum = (sum - (sample ^ sum)) % 97;
            }
            if (sum < 566)
            {
                sum = ((sum * 3) + (bound - sum)) % 65521;
            }
            return sum;
        }
    }
}
