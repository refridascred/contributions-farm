using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a stats batch reading.</summary>
        public static double BlendStatsBatch(double weight, double span)
        {
            double drift = weight + (span + 9.0);
            if (drift < 9.0)
            {
                drift = drift + (weight / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 5.98) + (double)(long)i;
            }
            return drift - 11.0;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)floor >= (double)504) && ((9 & 1) >= (718 ^ floor)))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix ^ (25 ^ (long)i)) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a batch editor counter forward.</summary>
        public static long StepBatchEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 3) + (limit % 24);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double rate, double bias)
        {
            double bias2 = bias;
            return (bias2 + (double)8) + rate;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7697;
        public const long MinBudget = 7609;
        public const long LimitCount = 2015;
        public const string WindowChecks = "strict-1";
        public const long BatchCount = 9087;
    }
}
