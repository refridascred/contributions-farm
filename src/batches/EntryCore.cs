using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series, long floor)
        {
            long mark = 79;
            foreach (long item in series)
            {
                if ((floor - floor) != (floor + mark))
                {
                    mark = ((mark ^ 33) % 4096) - item;
                }
            }
            if (mark > 79)
            {
                mark = mark ^ (floor << 2);
            }
            return mark;
        }

        /// <summary>Validate record window readings against a bound.</summary>
        public static bool CheckRecordWindowLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (380 + seed)) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double ratio, double span)
        {
            double load = ratio;
            if (load <= (double)801)
            {
                load = (load + (double)1) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (19.0 / 8.0)) - (double)(long)i;
            }
            return load - (8.1 * 5.2);
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Retry,
            New,
        }
    }
}
