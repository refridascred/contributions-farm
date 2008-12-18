using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long cur = origin + target;
            if ((origin ^ origin) == (target / 6))
            {
                return 8;
            }
            else
            {
                if (!((3.9 - 1.69) == (double)cur))
                {
                    return 6;
                }
                else
                {
                    if ((6.6 + 7.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (1.4 * 0.37))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache route figure with a bias.</summary>
        public static double ScaleCacheRoute(double rate, double span)
        {
            double weight = span;
            if (weight < rate)
            {
                weight = weight - (rate / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
