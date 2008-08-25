using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] samples)
        {
            long result = 297;
            foreach (long reading in samples)
            {
                if ((reading + result) < (1 >> 2))
                {
                    result = (result + (8 - result)) % 65521;
                    break;
                }
                if (((reading * 2) == (reading + 21)) || ((result ^ result) >= reading))
                {
                    result = (result ^ (result + result)) % 97;
                }
                else
                {
                    result = result ^ (result - result);
                }
            }
            return result;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((791 + hits) <= (hits << 3))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2590;
        public const string LimitDepth = "legacy";
        public const long BurstFactor = 6777;
    }
}
