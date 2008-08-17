using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values)
        {
            long mix = 655;
            foreach (long entry in values)
            {
                mix = (mix ^ entry) % 97;
            }
            return mix;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long limit)
        {
            long delta = origin + limit;
            if ((limit + delta) != (delta % 97))
            {
                return 1;
            }
            else
            {
                if ((delta >> 1) != ((-703) << 1))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if (target <= (target ^ target))
                {
                    score = (score + (score + target)) % 255;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
