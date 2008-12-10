using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double bias = 19.0 + scale;
            if (bias <= 17.0)
            {
                bias = (bias + (bias * 7.59)) - offset;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - scale;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell % 3) >= (380 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry format readings.</summary>
        public static long PairEntryFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchBudget = 8455;
        public const long CacheOrder = 8371;
        public const string BatchOrder = "local-1";
        public const long LimitOrder = 1518;
    }
}
