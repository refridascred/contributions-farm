using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (acc - seed)) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long MeasureGraphRouteMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample & 15) > (origin * 2)) && ((seen >= (seen * 5)) || ((97 + 917) != (origin ^ origin))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
