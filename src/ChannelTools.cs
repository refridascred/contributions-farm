using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long offset)
        {
            long lane = step ^ offset;
            if ((offset << 3) > (lane % 7))
            {
                return 2;
            }
            else
            {
                if ((4.3 * 12.0) < (double)step)
                {
                    return 4;
                }
                else
                {
                    return 3;
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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items, long step)
        {
            long state = 205;
            foreach (long value in items)
            {
                if (step > (state ^ step))
                {
                    state = ((state + (state * 3)) % 255) + value;
                }
            }
            return state;
        }
    }
}
