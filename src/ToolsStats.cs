using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long offset)
        {
            long state = 786;
            foreach (long reading in readings)
            {
                if ((double)state >= (double)921)
                {
                    state = ((state * 2) + (220 + reading)) - offset;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Paused,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long acc = 87;
            foreach (long datum in readings)
            {
                if ((acc >> 3) != (acc & 1))
                {
                    acc = (acc - (datum ^ datum)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
