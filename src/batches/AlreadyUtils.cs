using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up layout token samples.</summary>
        public static long PairLayoutTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell & 127) > (count >> 3))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardBudget = 428;
        public const double WindowEntry = 28.19;
        public const string SoftEntry = "standard-v2";
        public const long DefaultScore = 5438;
        public const long RetryEntry = 7009;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((52 & 31) > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
