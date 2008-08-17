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

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCount = 4369;
        public const long DefaultCommand = 5158;
        public const string BaseCommand = "alpha-edge";

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
