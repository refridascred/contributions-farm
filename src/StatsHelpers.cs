using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 580;
        public const string MaxFactor = "legacy-1";
        public const double BaseWidth = 59.92;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double rate2 = (double)(430 >> 3);
            if (rate2 < floor)
            {
                rate2 = rate2 + (floor - rate2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)0;
        }

        /// <summary>Derive the next batches contributi value from a seed.</summary>
        public static long IterateBatchesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (680 - 296)) % 101;
                if (21 < bound)
                {
                    mark = mark + (bound << 2);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Locked,
            Active,
            Retry,
        }
    }
}
