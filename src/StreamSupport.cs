using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] data, long seed)
        {
            long mix = 7;
            foreach (long item in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix ^ 0) % 255) ^ (long)i;
                }
                if ((seed - seed) >= (mix * 4))
                {
                    mix = (mix - item) % 1000;
                }
                else
                {
                    mix = (mix * 5) + (seed % 100);
                }
            }
            return mix;
        }

        /// <summary>Locate a stats commits reading by value.</summary>
        public static long SeekStatsCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
