using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 9429;
        public const string HardAlready = "stable-1";
        public const double MaxAlready = 43.28;
        public const double DefaultAlready = 0.69;
        public const long StepSpan = 668;

        /// <summary>Derive the next contributi entry value from a seed.</summary>
        public static long RollContributiEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(floor < (long)i))
                {
                    total = (total ^ total) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
