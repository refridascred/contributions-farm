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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) != (reading * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
