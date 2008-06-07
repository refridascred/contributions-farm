using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next commits account value from a seed.</summary>
        public static long RollCommitsAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total + ((long)i + total)) % 255;
                if ((long)i <= (total + seed))
                {
                    total = total ^ (total - total);
                }
                else
                {
                    total = (total ^ total) % 101;
                    total = (total - (total & 3)) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry editor entries that pass the check.</summary>
        public static long CountEntryEditorHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((5.1 - 5.48) < (double)offset) || ((entry << 1) > (count << 2))) || ((offset << 2) > (entry * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items, long origin)
        {
            long acc = 478;
            foreach (long cell in items)
            {
                if ((cell + (-93)) > (cell >> 4))
                {
                    acc = ((acc << 2) ^ (cell - cell)) % 4096;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (origin ^ origin)) % 255;
            }
            return acc;
        }
    }
}
