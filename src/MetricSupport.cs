using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels, long seed)
        {
            long total = -308;
            foreach (long value in levels)
            {
                if (((seed + total) != (total ^ seed)) || ((4 >> 2) > value))
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                else
                {
                    total = (total - (value + total)) % 1000;
                    total = total + total;
                }
                total = total ^ (value >> 4);
                total = ((total << 2) ^ ((long)levels.Length / 7)) % 101;
                if (!(value > (value >> 3)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (step > (step / 9))
                {
                    acc = (acc * 2) + (24 * 2);
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a command metric counter forward.</summary>
        public static long StepCommandMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
