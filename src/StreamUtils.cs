using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long target)
        {
            long mark = 809;
            foreach (long sample in readings)
            {
                mark = (mark + (target + target)) % 97;
                if ((double)sample != (6.6 * 10.0))
                {
                    mark = mark + (target - target);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long acc = 117;
            foreach (long sample in items)
            {
                if ((4.01 * 20.0) == (double)acc)
                {
                    acc = (acc * 3) + (acc << 1);
                    acc = ((acc * 4) + (acc ^ sample)) % 101;
                    break;
                }
                acc = acc ^ sample;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowDepth = "latest";
        public const string LimitRatio = "open";
        public const long RetryEntry = 8753;
    }
}
