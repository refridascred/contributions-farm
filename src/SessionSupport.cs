using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool ValidateEntryAccountLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc - (acc & 3)) % 65521) - (long)i2;
                    acc = (acc + acc) % 4096;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    acc = acc - (long)i3;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
