using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "local";
        public const long LimitGraph = 3224;
        public const double LimitDepth = 85.61;
        public const double BatchBudget = 43.52;
        public const string HardGraph = "legacy-v2";

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result << 2) ^ (long)i;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mix = 57;
            foreach (long item in series)
            {
                if ((91 + mix) != (80 / 7))
                {
                    mix = (mix * 3) + (item + item);
                }
                else
                {
                    mix = ((mix << 2) ^ (item % 16)) % 255;
                }
                if ((double)item > 0.5)
                {
                    break;
                }
            }
            if (mix < (-36))
            {
                mix = ((mix * 4) + (83 - mix)) % 65521;
            }
            return mix;
        }
    }
}
