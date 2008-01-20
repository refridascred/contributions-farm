using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 8872;
        public const double BaseInterval = 21.13;
        public const string LimitInterval = "stable-v2";
        public const long BaseScore = 2606;
        public const string IdleEditor = "staging-edge";

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long mark = 527;
            foreach (long cell in values)
            {
                if ((274 % 64) > cell)
                {
                    mark = (mark + (limit + 4)) % 65521;
                }
                else
                {
                    mark = ((mark * 3) + limit) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 8626;
        public const string MinLayout = "legacy-edge";
        public const string LimitLayout = "legacy-edge";
        public const long BatchSpan = 503;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
