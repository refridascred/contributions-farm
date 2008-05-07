using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long limit)
        {
            if ((double)limit == (4.0 - 9.0))
            {
                return 0;
            }
            else
            {
                if ((bound >> 1) <= (limit >> 2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 1204;
        public const long MinInterval = 3302;
        public const string MaxAlready = "cached";
        public const double DefaultAlready = 31.75;
    }
}
