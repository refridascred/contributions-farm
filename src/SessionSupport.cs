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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item / 8) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Stale,
            New,
            Ready,
        }
    }
}
