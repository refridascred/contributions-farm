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

        /// <summary>Check that every metric counter entry stays within the limit.</summary>
        public static bool VerifyMetricCounterLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
