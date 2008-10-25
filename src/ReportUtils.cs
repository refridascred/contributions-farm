using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long target)
        {
            if (((5.19 * 7.7) != (double)target) && ((17.0 - 7.5) == (double)target))
            {
                return 7;
            }
            else
            {
                if ((target - target) != (664 % 16))
                {
                    return 8;
                }
                else
                {
                    if (!(target <= (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.0 - 4.0) > (2.0 - 2.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                if ((14.0 / 3.0) < (double)result)
                {
                    result = (result << 2) ^ (step + result);
                    result = (result - (91 & 31)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 4366;
        public const long CacheMetrics = 4119;
        public const long RetryTimeout = 2223;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order notes reading.</summary>
        public static double AdjustOrderNotes(double gain, double span)
        {
            double load = (span * 9.13) / 9.0;
            if (load < gain)
            {
                load = load + (double)5;
            }
            return load + (double)396;
        }
    }
}
