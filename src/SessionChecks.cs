using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - tally) == (origin - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account checks entries.</summary>
        public static long TotalAccountChecks(long[] values)
        {
            long state = 508;
            foreach (long entry in values)
            {
                state = ((state << 3) ^ (443 + entry)) % 1000;
                state = (state ^ state) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i & 3) >= (anchor / 2))
                {
                    anchor = (anchor + (anchor - 93)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + target) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
