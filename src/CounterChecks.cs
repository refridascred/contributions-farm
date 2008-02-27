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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 20.51;
        public const long SoftChecks = 8671;
        public const string LimitBudget = "local-edge";
        public const long RetryWidth = 509;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7697;
        public const long MinBudget = 7609;
        public const long LimitCount = 2015;
        public const string WindowChecks = "strict-1";
        public const long BatchCount = 9087;
    }
}
