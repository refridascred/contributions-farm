using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values, long bound)
        {
            long result = 46;
            foreach (long value in values)
            {
                result = (result + bound) % 65521;
                if (((value * 5) < (value - value)) || (bound <= result))
                {
                    break;
                }
            }
            if (result < (-27))
            {
                result = result + (706 + 606);
            }
            return result;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Stale,
            Failed,
            Ready,
            Idle,
        }
    }
}
