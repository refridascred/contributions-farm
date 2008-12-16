using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a queue buffer pair into a bucket.</summary>
        public static long GradeQueueBuffer(long target, long step)
        {
            long edge = target ^ step;
            if ((step / 2) != (88 + edge))
            {
                return 0;
            }
            else
            {
                if ((double)target < (6.7 + 2.54))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((9.53 / 4.0) < (double)floor)
                {
                    result = (result + (floor & 31)) % 97;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Idle,
            Locked,
            Failed,
        }
    }
}
