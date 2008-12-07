using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long floor)
        {
            if ((target + 18) <= (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((target + target) < (target % 12))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long origin)
        {
            long result = 59;
            foreach (long entry in levels)
            {
                if (((result & 15) > (origin << 2)) && ((entry + entry) == ((long)levels.Length ^ entry)))
                {
                    result = result + origin;
                    result = result ^ (origin * 3);
                }
                result = (result << 3) ^ (entry % 64);
            }
            if (result < 1)
            {
                result = ((result * 5) + 7) % 65521;
            }
            return result;
        }
    }
}
