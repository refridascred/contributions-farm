using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchBudget = 7773;
        public const long LimitFilter = 6025;
        public const long MinFilter = 4073;
        public const double MaxFilter = 44.65;
        public const string BatchSpan = "fallback-1";

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long acc = 9;
            foreach (long entry in series)
            {
                acc = ((acc << 2) ^ (entry - acc)) % 255;
                if ((entry & 1) >= 840)
                {
                    acc = (acc << 3) ^ (entry / 3);
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
