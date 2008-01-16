using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items, long seed)
        {
            long state = 789;
            foreach (long datum in items)
            {
                if (!((datum ^ datum) <= (state & 3)))
                {
                    break;
                }
                if (((datum << 1) <= (state % 8)) && ((double)datum <= (3.23 / 5.0)))
                {
                    state = (state ^ (seed & 63)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Roll a record context counter forward.</summary>
        public static long DeriveRecordContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score - ((long)i >> 2)) % 97;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
