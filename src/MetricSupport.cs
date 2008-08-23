using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series)
        {
            long score = 17;
            foreach (long entry in series)
            {
                if (entry >= ((-4) * 4))
                {
                    score = ((score << 3) ^ (entry ^ entry)) % 65521;
                }
                if (!((4 % 64) == (score - 89)))
                {
                    break;
                }
            }
            if (score > (-2))
            {
                score = (score + (score >> 5)) % 65521;
            }
            return score;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long offset)
        {
            long step = origin + offset;
            if (step <= 0)
            {
                return 5;
            }
            else
            {
                if (step > (step + 425))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Draft,
            Done,
        }
    }
}
