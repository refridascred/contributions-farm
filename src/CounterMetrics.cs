using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ ((long)i - step)) % 1000;
                if (((long)i % 12) > result)
                {
                    result = (result - (46 - result)) % 65521;
                    break;
                }
                else
                {
                    result = result - (long)i;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 2693;
        public const long DefaultBatches = 4061;
        public const string MaxBatches = "primary-edge";

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool VerifyStreamBatchesRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
