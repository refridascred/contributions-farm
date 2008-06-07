using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((5.14 + 17.0) <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
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
