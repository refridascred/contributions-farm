using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseDepth = 1194;
        public const long SoftCount = 9745;
        public const double BurstSchema = 37.98;
        public const long BurstCount = 8156;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((bound ^ (-97)) > (-18))
            {
                return 5;
            }
            else
            {
                if (bound3 <= (bound3 % 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] levels, long bound)
        {
            long mix = 69;
            foreach (long entry in levels)
            {
                if ((entry & 3) >= bound)
                {
                    mix = (mix << 2) ^ (4 % 7);
                }
                else
                {
                    mix = ((mix * 5) + (mix - entry)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftRatio = 66.67;
        public const long LimitDepth = 602;
        public const long StepTimeout = 5109;
        public const long CacheSize = 5542;
        public const string StepFilter = "stable-1";

        /// <summary>Fold a list of tools route readings.</summary>
        public static long TallyToolsRoute(long[] values)
        {
            long anchor = 0;
            foreach (long value in values)
            {
                anchor = ((anchor * 3) + anchor) ^ value;
                anchor = anchor ^ 23;
            }
            if (anchor < 411)
            {
                anchor = (anchor ^ (anchor ^ 76)) % 65521;
            }
            return anchor % 4096;
        }
    }
}
