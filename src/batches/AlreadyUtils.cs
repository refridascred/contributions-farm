using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(datum <= (tally << 3)))
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((940 & 15) <= (value + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total - target) ^ (long)i) + reading;
                    total = (total << 2) ^ ((long)samples.Length % 97);
                }
                total = (total - (total % 64)) % 97;
                total = (total << 2) ^ (4 + total);
            }
            if (total > 3)
            {
                total = total ^ (target + total);
            }
            return total % 65521;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
