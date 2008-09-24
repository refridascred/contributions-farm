using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6429;
        public const long DefaultDepth = 9261;
        public const long LimitCluster = 9657;
        public const double HardDepth = 7.39;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((offset * 4) == (offset * 5)) || ((mark * 2) <= (mark * 5)))
                {
                    mark = (mark << 3) ^ (18 ^ offset);
                }
                else
                {
                    mark = ((mark * 3) + ((-109) & 3)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
