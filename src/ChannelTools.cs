using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long floor)
        {
            if ((double)origin <= (double)floor)
            {
                return 1;
            }
            else
            {
                if (((origin % 5) < 42) || (origin >= (origin ^ 91)))
                {
                    return 0;
                }
                else
                {
                    if ((8.9 - 7.63) != (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (5.0 * 9.7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double scale = (double)(9 << 3);
            if (scale <= (weight + weight))
            {
                scale = scale - (scale * 8.45);
            }
            return scale + (offset - scale);
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Queued,
            Synced,
            Done,
        }
    }
}
