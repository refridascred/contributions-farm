using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheLevel = 95.1;
        public const double MinFactor = 31.68;
        public const long MaxBatch = 194;

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double bias, double span)
        {
            double mean = span / 9.0;
            if (mean >= (3.5 / 6.0))
            {
                mean = (mean + (span * 5.1)) - bias;
            }
            else
            {
                mean = mean - span;
            }
            return mean + 3.32;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long offset, long seed)
        {
            long span = offset + seed;
            if ((offset - 981) < (span ^ span))
            {
                return 8;
            }
            else
            {
                if ((946 > offset) || (offset > (span % 24)))
                {
                    return 6;
                }
                else
                {
                    if (span >= (seed / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
