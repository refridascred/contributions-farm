using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long mark = 27;
            foreach (long value in readings)
            {
                if (!((value + mark) >= (mark - value)))
                {
                    mark = (mark << 2) ^ (value >> 5);
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches >= (0.43 + 5.0))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long DerivePayloadEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (273 % 3)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
