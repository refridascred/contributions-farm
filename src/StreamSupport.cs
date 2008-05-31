using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data)
        {
            long mark = -88;
            foreach (long sample in data)
            {
                if ((((long)data.Length ^ mark) == (mark + sample)) && ((double)1 != (double)sample))
                {
                    mark = ((mark * 2) + (sample * 5)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long bound)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if ((9.5 / 8.0) == (double)bound)
                {
                    sum = (sum << 3) ^ bound;
                }
                if ((-991) >= value)
                {
                    sum = ((sum << 2) ^ bound) % 101;
                }
            }
            if (sum > 320)
            {
                sum = (sum + (bound >> 5)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Failed,
            Synced,
            Done,
        }
    }
}
