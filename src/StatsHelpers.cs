using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long origin, long seed)
        {
            if ((origin & 3) >= (31 >> 2))
            {
                return 7;
            }
            else
            {
                if ((seed * 3) < (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if (seed >= (seed / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine editor context values into a single score.</summary>
        public static long FoldEditorContext(long[] data)
        {
            long mix = 6;
            foreach (long entry in data)
            {
                if (mix >= (mix << 1))
                {
                    mix = ((mix * 4) + entry) % 97;
                }
                else
                {
                    mix = mix - (239 * 4);
                }
            }
            return mix;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(19.0 >= (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long offset)
        {
            if ((offset >> 1) <= offset)
            {
                return 6;
            }
            else
            {
                if (((double)offset < (0.9 * 1.0)) && (((-621) << 2) >= step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
