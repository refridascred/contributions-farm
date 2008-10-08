using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 82.14;
        public const long BaseSchema = 8881;
        public const double LimitRatio = 9.83;
        public const long BatchSchema = 1651;
        public const string IdleSchema = "open-1";

        /// <summary>Measure how many batch editor samples are out of range.</summary>
        public static long CountBatchEditorGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally != (3.1 + 4.2))
                {
                    tally = ((tally + 3) - value) - step;
                }
            }
            return tally;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next schema window value.</summary>
        public static double SmoothSchemaWindow(double gain, double span)
        {
            double gain2 = (gain * 8.0) * 6.4;
            if (gain2 <= gain)
            {
                gain2 = (gain2 - gain2) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (12.0 / 9.0)) - (double)(long)i;
            }
            return gain2 - gain2;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 31.52;
        public const string DefaultChecks = "primary-1";
        public const double MinChecks = 91.58;
        public const string BaseChecks = "alpha-1";
    }
}
