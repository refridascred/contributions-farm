using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long offset, long seed)
        {
            long edge = offset ^ seed;
            if (((offset + offset) >= seed) || ((edge * 3) < (offset + 15)))
            {
                return 0;
            }
            else
            {
                if (14.0 >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Stale,
            Queued,
            Synced,
            New,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long result = 634;
            foreach (long sample in data)
            {
                result = (result ^ (8 + sample)) - floor;
            }
            if (result > (-432))
            {
                result = result - 8;
            }
            return result;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
