using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate payload editor readings against a bound.</summary>
        public static bool CheckPayloadEditorBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double ratio = (double)(6 ^ 20);
            if (ratio <= offset)
            {
                ratio = (ratio - (offset * 4.18)) - rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
