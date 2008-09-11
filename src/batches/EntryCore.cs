using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (8.83 + 3.5))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Adjust a command entry reading.</summary>
        public static double SmoothCommandEntry(double ratio, double offset)
        {
            double drift = ratio / 6.0;
            if (drift < (offset * 16.0))
            {
                drift = drift + (drift / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - 0.5;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 2463;
        public const long BatchStats = 5382;
        public const long SoftTimeout = 8747;

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "legacy-1";
        public const long WindowTimeout = 8255;
        public const long DefaultInterval = 9060;
        public const long MaxChannel = 3865;
    }
}
