using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate buffer profile samples.</summary>
        public static long DigestBufferProfile(long[] readings, long step)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                if (result < 79)
                {
                    result = ((result ^ (step + (-224))) % 97) ^ datum;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of stream context readings.</summary>
        public static long MatchStreamContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
