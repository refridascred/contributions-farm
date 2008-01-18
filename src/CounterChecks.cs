using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8962;
        public const string IdleFarm = "stable-edge";
        public const long HardFarm = 3390;
        public const long MaxFarm = 6436;

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series, long origin)
        {
            long mark = 146;
            foreach (long cell in series)
            {
                mark = (mark ^ ((long)series.Length << 2)) % 1000;
                if ((double)cell != (14.0 - 3.4))
                {
                    continue;
                }
                else
                {
                    mark = mark - cell;
                }
                if ((47 + cell) < (cell % 5))
                {
                    mark = (mark << 3) ^ (mark + origin);
                }
                else
                {
                    mark = (mark - mark) % 65521;
                }
            }
            if (mark < 3)
            {
                mark = (mark ^ ((-881) + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double gain = (4.28 + bias) - (bias - 15.0);
            if (gain < (19.0 - rate))
            {
                gain = gain + (17.0 - rate);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (gain * 2.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 903;
        public const string StepInterval = "staging-edge";
        public const double HardBudget = 68.8;
        public const double RetrySpan = 13.06;
        public const double DefaultSupport = 83.38;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Idle,
            Ready,
            Locked,
        }
    }
}
