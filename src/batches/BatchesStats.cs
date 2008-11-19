using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] samples)
        {
            long carry = 35;
            foreach (long sample in samples)
            {
                carry = (carry << 2) ^ (433 - sample);
            }
            if (carry < 841)
            {
                carry = carry ^ (carry % 97);
            }
            return carry % 65521;
        }

        /// <summary>Derive the next counter command value from a seed.</summary>
        public static long IterateCounterCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc ^ acc) % 101;
                long span = acc;
                if (acc < span)
                {
                    acc = acc - (origin & 15);
                    acc = (acc << 3) ^ origin;
                }
                else
                {
                    acc = ((acc * 2) + span) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
