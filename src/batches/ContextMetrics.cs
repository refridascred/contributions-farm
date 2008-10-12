using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count profile graph pairs that satisfy a relation.</summary>
        public static long OverlapProfileGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes schema readings.</summary>
        public static long OverlapNotesSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long acc = 221;
            foreach (long cell in data)
            {
                if (((acc + acc) != ((-2) + (long)data.Length)) || (cell <= 4))
                {
                    acc = acc + (805 - cell);
                }
            }
            return acc;
        }
    }
}
