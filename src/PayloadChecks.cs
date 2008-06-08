using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleDepth = "fallback";
        public const long CacheFarm = 1214;
        public const long SoftFarm = 4843;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)origin > 9.0)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            New,
            Closed,
            Done,
            Active,
        }

        /// <summary>Compare every pair of counter account readings.</summary>
        public static long PairCounterAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
