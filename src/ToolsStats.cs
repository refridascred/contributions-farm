using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long acc = 863;
            foreach (long value in series)
            {
                acc = (((acc << 2) ^ (7 << 2)) % 65521) + value;
            }
            return acc;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) < (hits >> 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data, long seed)
        {
            long carry = -412;
            foreach (long value in data)
            {
                double mean = 1.9 * 5.9;
                if (!(mean >= (mean - mean)))
                {
                    mean = (mean - (double)seed) + (double)value;
                }
                if ((carry % 100) == (seed / 2))
                {
                    carry = (carry << 2) ^ (carry / 6);
                }
            }
            return carry;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 2) ^ (long)i;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score ^ score) % 255) ^ (long)i2;
                }
                score = (score * 5) + (step % 60);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
