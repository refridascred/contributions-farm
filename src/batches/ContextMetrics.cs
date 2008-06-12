using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((2.0 * 2.2) > (double)bound)
                {
                    break;
                }
                else
                {
                    result = (result + (result * 5)) % 97;
                }
                if (!(bound <= result))
                {
                    result = result ^ (result << 2);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= (offset * 3.5))
            {
                rate2 = rate2 - 3.59;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (double)11;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - 45) > (count * 2))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Adjust a schema already reading.</summary>
        public static double SmoothSchemaAlready(double gain, double span)
        {
            double mean = (double)(84 - 622);
            if (mean >= 7.66)
            {
                mean = (mean + (mean + mean)) - span;
            }
            else
            {
                mean = mean + (double)64;
            }
            return mean - gain;
        }
    }
}
