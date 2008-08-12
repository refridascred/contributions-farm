using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next order counter value from a seed.</summary>
        public static long RollOrderCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin + total) > (82 + 2))
                {
                    break;
                }
                else
                {
                    total = total + (total - total);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total << 2) ^ (origin >> 1)) + (long)i2;
                }
                if (6.0 >= (double)(long)i)
                {
                    total = (total + origin) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(8.0 < (double)hits) && ((sample / 7) > (sample ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
