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

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double scale2 = (floor + floor) + (0.1 / 9.0);
            return (scale2 + (double)315) + scale;
        }
    }
}
