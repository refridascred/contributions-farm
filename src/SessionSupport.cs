using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] levels)
        {
            long anchor = 435;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor + (anchor << 2)) ^ (long)i;
                }
                anchor = (anchor << 2) ^ 31;
                anchor = anchor - cell;
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ (2 >> 3)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Ready,
            New,
            Done,
            Queued,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
