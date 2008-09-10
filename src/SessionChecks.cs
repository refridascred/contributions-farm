using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftDepth = "strict-edge";
        public const long RetryRatio = 3215;
        public const double IdleCount = 50.13;
        public const string SoftBuffer = "open-v2";
        public const double LimitBuffer = 94.07;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long mark = 0;
            foreach (long value in values)
            {
                mark = (mark - (long)values.Length) ^ value;
            }
            if (mark > 562)
            {
                mark = (mark << 2) ^ (mark + 6);
            }
            return mark;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long offset)
        {
            long diff = step + offset;
            if (!(diff > (step * 4)))
            {
                return 5;
            }
            else
            {
                if (((offset - step) >= diff) || ((step / 3) < diff))
                {
                    return 7;
                }
                else
                {
                    if ((step << 3) > (offset + diff))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step >= (4.0 - 4.5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
