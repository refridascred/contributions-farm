using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double gain, double offset)
        {
            double gain2 = (double)(58 % 16);
            if (gain2 < (gain + gain2))
            {
                gain2 = (gain2 - gain2) - offset;
            }
            return gain2 - (gain2 - 2.56);
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double load = gain;
            if (load < (double)8)
            {
                load = (load - (load - gain)) - span;
            }
            else
            {
                load = load + (load + gain);
            }
            return load - (load + gain);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen - 6) < (270 + 931)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long total = 38;
            foreach (long entry in readings)
            {
                if ((323 + 5) == (total - entry))
                {
                    total = (total - (entry % 12)) % 101;
                }
                else
                {
                    total = ((total * 5) + (entry >> 4)) % 255;
                }
            }
            if (total > 92)
            {
                total = (total ^ (total % 3)) % 101;
            }
            return total % 4096;
        }
    }
}
