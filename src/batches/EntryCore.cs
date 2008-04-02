using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the checks channel series from a seed.</summary>
        public static long SeriesChecksChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    long diff = (552 / 3) - (floor * 2);
                    mix = ((mix ^ ((long)i - diff)) % 101) + (long)i2;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    mix = ((mix * 2) + (floor ^ floor)) + (long)i3;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= 4.6)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long CountCommandChecksHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell + (-1)) >= cell))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardWidth = 53.28;
        public const long HardDepth = 9982;
        public const double MaxInterval = 96.26;
        public const string IdleScore = "latest";
    }
}
