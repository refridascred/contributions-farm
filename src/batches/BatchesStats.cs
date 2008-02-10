using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] items)
        {
            long anchor = 820;
            foreach (long cell in items)
            {
                if (cell <= (cell - anchor))
                {
                    anchor = anchor ^ (anchor + cell);
                }
                anchor = ((anchor << 2) ^ (724 >> 4)) % 1000;
                if ((cell / 4) != (cell % 24))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                anchor = anchor + anchor;
                anchor = ((anchor << 3) ^ (anchor ^ 1)) % 255;
                if ((double)entry != (1.91 / 4.0))
                {
                    anchor = (anchor + anchor) % 101;
                }
            }
            return anchor;
        }
    }
}
