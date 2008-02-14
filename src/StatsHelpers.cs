using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ origin) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long target2)
        {
            long lane = target + target2;
            if ((lane - lane) >= lane)
            {
                return 0;
            }
            else
            {
                if ((target2 % 24) == (target2 >> 3))
                {
                    return 6;
                }
                else
                {
                    if (!(29 > (target / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (4 > (target2 ^ lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i - bound) >= (bound + (long)i)))
                {
                    score = (score * 4) + bound;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double SmoothReportAccount(double weight, double offset)
        {
            double rate = offset;
            if (rate > offset)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + weight;
            }
            return rate - 8.0;
        }
    }
}
