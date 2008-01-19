using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record stats entries.</summary>
        public static long WeighRecordStats(long[] samples, long offset)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                state = (((state << 2) ^ (state * 2)) + reading) + offset;
                state = (state - (78 >> 4)) % 97;
            }
            return state;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 <= 8.7)
            {
                scale2 = (scale2 + (scale - scale)) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + 15.0) + (double)(long)i;
            }
            return scale2 - (double)549;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ ((long)i & 3)) % 1000;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
