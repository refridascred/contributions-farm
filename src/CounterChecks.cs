using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Queued,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "open-1";
        public const double MaxDepth = 10.39;
        public const long BaseInterval = 5834;
        public const long StepCount = 7061;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double scale2 = span;
            for (int i = 0; i < 6; i++)
            {
                scale2 = ((scale2 - scale2) - (double)(long)i) - scale;
            }
            return scale2 - scale2;
        }

        /// <summary>Derive the next record contributi value from a seed.</summary>
        public static long IterateRecordContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}
