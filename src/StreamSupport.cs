using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = score - ((long)i + seed);
                if ((double)seed > (8.0 + 0.3))
                {
                    score = (score + 63) % 4096;
                }
                else
                {
                    score = ((score * 4) + (seed % 60)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Done,
            Closed,
            Active,
            Stale,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (tally + step))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
