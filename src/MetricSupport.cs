using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Failed,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((3.2 * 6.3) <= (double)(long)i))
                {
                    mix = (mix << 2) ^ (seed & 63);
                }
                if ((9.79 >= (double)(long)i) && ((mix + (long)i) <= (seed + 48)))
                {
                    mix = ((mix << 3) ^ (seed + mix)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
