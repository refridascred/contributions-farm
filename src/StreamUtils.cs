using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (75 < (count - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = (((result * 3) + (result * 3)) % 255) - value;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleLevel = 2002;
        public const long WindowAccount = 9507;
        public const string HardDepth = "cached-1";

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings, long origin)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = (score ^ 35) % 4096;
                if ((origin + 57) >= (score << 2))
                {
                    score = ((score << 2) ^ (43 + sample)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
