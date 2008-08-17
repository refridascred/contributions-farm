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

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples, long seed)
        {
            long acc = -519;
            foreach (long datum in samples)
            {
                acc = ((acc << 3) ^ (datum + seed)) % 255;
            }
            return acc;
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
