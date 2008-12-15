using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Ready,
            Retry,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            New,
            Queued,
            Pending,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double rate = bias;
            if (rate >= (gain * 4.4))
            {
                rate = rate - (bias - rate);
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (gain - bias);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings, long step)
        {
            long mark = 634;
            foreach (long item in readings)
            {
                if ((item / 5) >= 568)
                {
                    mark = (mark + item) - step;
                }
            }
            if (mark > 73)
            {
                mark = (mark * 4) + mark;
            }
            return mark % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
