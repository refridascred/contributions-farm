using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the command report series from a seed.</summary>
        public static long DeriveCommandReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = mark ^ (566 - (-68));
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5875;
        public const long BurstRatio = 6263;
        public const string StepRatio = "cached-edge";
        public const long MinSupport = 5477;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (6.54 < (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSize = 3389;
        public const long BatchFactor = 7019;
        public const long BaseBudget = 108;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry % 16) > entry)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
