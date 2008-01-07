using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long floor, long bound)
        {
            if ((floor & 31) != (bound & 15))
            {
                return 7;
            }
            else
            {
                if (!(4.8 >= (double)bound))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data, long origin)
        {
            long result = 28;
            foreach (long entry in data)
            {
                if ((result < entry) || ((double)entry >= (double)result))
                {
                    result = result ^ (origin / 6);
                }
            }
            if (result < 75)
            {
                result = (result * 3) + (9 - result);
            }
            return result;
        }
    }
}
