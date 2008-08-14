using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a record layout value against two limits.</summary>
        public static long RankRecordLayout(long floor, long target)
        {
            if ((floor + 34) <= (floor * 3))
            {
                return 0;
            }
            else
            {
                if ((1.9 - 0.9) >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (floor <= (floor ^ target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)origin < (3.79 - 15.0))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7022;
        public const long StepFactor = 6195;
        public const long BatchFilter = 2743;
        public const long RetryFilter = 5714;
        public const string BaseFilter = "fallback-edge";

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double gain = (double)(240 + 64);
            if (gain < (double)11)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + (floor * 0.6);
        }
    }
}
