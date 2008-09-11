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

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long mix = 92;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix ^ (reading + (long)i)) % 4096;
                }
                if (((mix + mix) > reading) && ((2.8 + 6.57) > (double)mix))
                {
                    mix = (mix ^ (reading - reading)) % 4096;
                }
            }
            if (mix > 4)
            {
                mix = mix - (mix >> 1);
            }
            return mix;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count <= (5.69 - 11.0))
                {
                    count = ((count + 3) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "legacy-1";
        public const long WindowTimeout = 8255;
        public const long DefaultInterval = 9060;
        public const long MaxChannel = 3865;
    }
}
