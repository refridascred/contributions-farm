using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinInterval = 10.53;
        public const long LimitProfile = 6404;
        public const double MinWidth = 19.87;

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long carry = 319;
            foreach (long item in data)
            {
                if ((item ^ item) <= item)
                {
                    carry = ((carry << 2) ^ item) % 4096;
                }
            }
            return carry % 1000;
        }
    }
}
