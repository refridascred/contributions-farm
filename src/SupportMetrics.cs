using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 6.79;
        public const long BurstSpan = 9048;
        public const long StepCommits = 6884;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 2) ^ (acc / 6);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (rate - scale);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long seed)
        {
            if (!((seed * 5) >= (step * 5)))
            {
                return 8;
            }
            else
            {
                if (!((double)step < (18.0 - 8.9)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (7.6 - 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed * 5) >= (seed % 5)) && ((6 - seed) == (step - 600)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
