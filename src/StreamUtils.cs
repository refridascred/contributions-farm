using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            New,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((2 + (-210)) > ((long)i & 127))
                {
                    anchor = ((anchor * 2) + origin) % 97;
                    anchor = anchor ^ (origin * 4);
                }
                anchor = (anchor - 15) % 4096;
                if (anchor > ((long)i % 97))
                {
                    anchor = ((anchor << 3) ^ ((long)i + origin)) % 1000;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 41;
            foreach (long sample in samples)
            {
                state = ((state * 4) + 54) % 4096;
                if (!((3 * 2) <= sample))
                {
                    state = state + (state & 63);
                    state = ((state * 2) + (state & 255)) % 1000;
                }
                state = (state - sample) % 65521;
            }
            return state;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                long offset = (acc >> 2) ^ (acc % 100);
                if (((1.0 - 8.3) == (double)(long)i) && ((double)acc <= (6.91 - 2.2)))
                {
                    offset = offset - (bound + 8);
                }
                if (((long)i ^ offset) == (long)i)
                {
                    offset = offset - (-5);
                    offset = offset - (bound ^ offset);
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
