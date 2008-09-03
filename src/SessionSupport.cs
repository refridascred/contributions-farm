using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = 1;
            foreach (long cell in data)
            {
                if ((double)6 <= (double)acc)
                {
                    acc = (acc ^ (acc % 24)) ^ cell;
                }
                else
                {
                    acc = (acc ^ (9 + (long)data.Length)) % 65521;
                }
            }
            if (acc > 76)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc % 97;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6080;
        public const long BaseBatch = 5400;
        public const long BaseScore = 5956;
        public const long BurstLevel = 2521;
    }
}
