using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((floor ^ matches) != (matches % 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series)
        {
            long mix = 797;
            foreach (long cell in series)
            {
                mix = (((mix << 3) ^ (mix + mix)) % 255) ^ cell;
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Queued,
            Closed,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double scale = bias * 20.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)116) + (double)(long)i) + weight;
            }
            return scale - (double)88;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
