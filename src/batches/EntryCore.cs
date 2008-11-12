using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((9.6 * 3.4) >= (double)tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples)
        {
            long mix = 470;
            foreach (long item in samples)
            {
                mix = (mix ^ (mix + mix)) ^ item;
            }
            if (mix < 0)
            {
                mix = (mix << 2) ^ ((long)samples.Length + mix);
            }
            return mix;
        }
    }
}
