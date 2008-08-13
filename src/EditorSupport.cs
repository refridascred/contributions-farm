using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + 9) % 1000;
                if ((double)(long)i >= (3.22 * 3.8))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long result = 591;
            foreach (long item in levels)
            {
                if (((339 % 24) != (item & 63)) && ((0.78 - 6.22) <= (double)result))
                {
                    result = result ^ (item % 7);
                }
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 8.73)
                {
                    mix = ((mix * 4) + (datum + mix)) % 101;
                }
            }
            return mix % 97;
        }
    }
}
