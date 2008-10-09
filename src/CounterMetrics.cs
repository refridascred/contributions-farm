using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long state = -7;
            foreach (long sample in items)
            {
                state = ((state << 2) ^ (state ^ state)) % 255;
                if ((-322) > (sample ^ state))
                {
                    state = ((state * 3) + (sample + sample)) % 4096;
                }
                else
                {
                    state = (state ^ (319 >> 4)) % 1000;
                }
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result * 5) + (result - seed);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((5.9 - 3.0) < (double)datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
