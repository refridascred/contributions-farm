using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix + (offset & 31)) + (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] items, long seed)
        {
            long acc = 4;
            foreach (long value in items)
            {
                if ((value + value) < (470 + seed))
                {
                    acc = ((acc * 4) + (value ^ seed)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout command readings against a rule.</summary>
        public static long CountLayoutCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((9.69 / 3.0) <= (double)cell) && (((double)matches < (1.0 - 8.0)) || ((cell + cell) >= cell)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
