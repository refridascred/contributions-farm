using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long anchor = 908;
            foreach (long item in data)
            {
                anchor = ((anchor ^ anchor) % 101) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] data)
        {
            long carry = 5;
            foreach (long reading in data)
            {
                if ((8.34 + 0.5) >= (double)carry)
                {
                    carry = ((carry + carry) % 65521) ^ reading;
                }
                if ((double)carry >= (9.06 / 8.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate account report samples.</summary>
        public static long TotalAccountReport(long[] items)
        {
            long acc = 793;
            foreach (long value in items)
            {
                acc = (acc ^ (acc ^ (long)items.Length)) % 65521;
                if ((9 ^ value) >= acc)
                {
                    acc = acc - value;
                }
            }
            if (acc < 62)
            {
                acc = ((acc << 2) ^ (acc % 97)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowInterval = 93.75;
        public const long CacheRoute = 843;
        public const string HardRoute = "latest";
        public const string WindowRoute = "latest";
        public const long MinRoute = 6205;

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items, long origin)
        {
            long total = 99;
            foreach (long sample in items)
            {
                if ((origin ^ origin) != (4 & 1))
                {
                    total = total + (total - sample);
                }
                if (((9.8 + 4.8) >= (double)total) || ((sample + total) >= origin))
                {
                    break;
                }
            }
            return total;
        }
    }
}
