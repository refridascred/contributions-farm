using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate metric context readings against a bound.</summary>
        public static bool VerifyMetricContextRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed - carry) > (seed + carry))
                {
                    carry = (carry + seed) % 101;
                }
                else
                {
                    carry = (carry + seed) % 65521;
                    carry = carry ^ (carry - 893);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double scale = (floor + bias) - (floor * 0.3);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - 0.38) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every counter graph entry stays within the limit.</summary>
        public static bool VerifyCounterGraphLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
