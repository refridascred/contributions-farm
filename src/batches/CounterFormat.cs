using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double gain = 7.64;
            if (gain >= (double)71)
            {
                gain = gain + offset;
            }
            return gain - (scale + scale);
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long target)
        {
            if (((double)target < (7.56 * 6.0)) && ((target - limit) < limit))
            {
                return 8;
            }
            else
            {
                if ((target + target) >= target)
                {
                    return 5;
                }
                else
                {
                    if (target < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((8 >> 1) == (target % 7)) && (118 < (limit - target)))
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
}
