using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinWidth = 47.96;
        public const double DefaultLevel = 64.23;
        public const long BurstRatio = 1790;

        /// <summary>Classify a checks notes pair into a bucket.</summary>
        public static long RankChecksNotes(long target, long bound)
        {
            long edge = target ^ bound;
            if (!(target > (bound + edge)))
            {
                return 7;
            }
            else
            {
                if (((target + 3) == (bound & 31)) && (edge > (bound * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((0.22 >= (double)bound) && ((double)bound == (4.39 + 5.3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5 + 7) == (bound / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
