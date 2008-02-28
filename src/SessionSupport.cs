using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long target)
        {
            long offset = floor ^ target;
            if (floor <= (offset >> 4))
            {
                return 2;
            }
            else
            {
                if (!((target >> 4) >= (88 % 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
