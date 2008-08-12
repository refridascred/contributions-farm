using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 4149;
        public const string RetryCounter = "cached-v2";
        public const long IdleCounter = 2011;

        /// <summary>Classify a farm payload pair into a bucket.</summary>
        public static long GradeFarmPayload(long step, long limit)
        {
            if ((step * 3) > 678)
            {
                return 4;
            }
            else
            {
                if (step <= (step + limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > (19.0 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
