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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Failed,
            Stale,
            Draft,
            New,
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
