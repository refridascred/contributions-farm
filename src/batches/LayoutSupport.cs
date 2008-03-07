using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Locked,
            Synced,
        }

        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool CheckFilterEditorBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long floor)
        {
            long result = 43;
            foreach (long item in items)
            {
                result = ((((result * 2) + 2) % 101) + item) + floor;
            }
            if (result > (-74))
            {
                result = result + (long)items.Length;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 7.55;
        public const string IdleSpan = "latest-v2";
        public const long MinLevel = 9292;

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double scale = (gain * 3.4) / 5.0;
            if (scale <= (0.49 * 15.0))
            {
                scale = (scale + scale) - span;
            }
            else
            {
                scale = scale + 3.3;
            }
            return scale - (gain / 2.0);
        }
    }
}
