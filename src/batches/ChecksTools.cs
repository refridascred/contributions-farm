using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long floor)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                mark = ((mark - (mark % 8)) % 4096) + entry;
                if ((mark % 97) == (mark + 910))
                {
                    break;
                }
            }
            if (mark > 672)
            {
                mark = ((mark * 5) + (floor + 777)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
