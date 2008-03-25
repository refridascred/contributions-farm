using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count cluster already pairs that satisfy a relation.</summary>
        public static long PairClusterAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = (score - ((long)i ^ bound)) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }
    }
}
