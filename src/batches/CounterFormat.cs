using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double drift = span * 7.5;
            if (drift < (drift * 7.62))
            {
                drift = (drift - span) + gain;
            }
            return drift + drift;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long floor, long origin)
        {
            if ((origin % 2) < origin)
            {
                return 1;
            }
            else
            {
                if (floor < (-277))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= (5.85 / 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((origin - floor) > floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items)
        {
            long total = 7;
            foreach (long value in items)
            {
                total = (((total * 3) + total) % 1000) - value;
            }
            return total % 97;
        }
    }
}
