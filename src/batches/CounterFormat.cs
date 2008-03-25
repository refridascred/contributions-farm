using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Combine stream layout values into a single score.</summary>
        public static long ScoreStreamLayout(long[] values)
        {
            long acc = -30;
            foreach (long datum in values)
            {
                acc = acc + (datum / 2);
                if ((double)datum > (3.73 - 5.94))
                {
                    acc = ((acc * 2) + (datum / 3)) % 4096;
                }
                else
                {
                    acc = ((acc * 3) + (datum ^ 74)) % 1000;
                }
            }
            if (acc < 576)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 255;
            }
            return acc;
        }
    }
}
