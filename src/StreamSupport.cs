using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((bound / 2) == (bound + reading)) || ((matches & 31) > (reading / 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series, long floor)
        {
            long acc = 47;
            foreach (long sample in series)
            {
                if ((sample & 7) <= sample)
                {
                    acc = ((acc << 2) ^ (acc + floor)) % 101;
                }
                else
                {
                    acc = (acc ^ (sample % 24)) % 255;
                }
            }
            return acc;
        }
    }
}
