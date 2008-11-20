using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 8841;
        public const long DefaultSize = 7948;
        public const string MinDepth = "primary-1";
        public const long WindowSchema = 8481;
        public const long StepSchema = 3247;

        /// <summary>Roll a support token counter forward.</summary>
        public static long SeriesSupportToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = (total - ((long)i + floor)) % 97;
                total = total - total;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
