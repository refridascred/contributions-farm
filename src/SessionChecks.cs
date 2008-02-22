using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series)
        {
            long acc = 7;
            foreach (long item in series)
            {
                if (item > (item & 3))
                {
                    acc = (acc * 3) + (acc - acc);
                }
                else
                {
                    acc = (acc - (item / 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double load = (double)79 + (double)3;
            if (load < offset)
            {
                load = load + (rate * 4.33);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (offset - rate)) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long offset)
        {
            long next = step + offset;
            if (next > (step >> 3))
            {
                return 3;
            }
            else
            {
                if ((579 & 1) <= next)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
