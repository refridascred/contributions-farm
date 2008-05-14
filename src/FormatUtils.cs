using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1158;
        public const long StepLevel = 1141;
        public const double CacheLevel = 0.73;
        public const long LimitDepth = 2913;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= 9.0)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (ratio - 8.38);
            }
            return bias + (double)4;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the payload token entries that pass the check.</summary>
        public static long AuditPayloadTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + seen) < (1 % 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((seed << 2) <= (count >> 4))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
