using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 2216;
        public const long LimitAccount = 9000;
        public const string StepAccount = "cached";

        /// <summary>Compare every pair of support format readings.</summary>
        public static long CompareSupportFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long ScoreRecordGraph(long[] items)
        {
            long total = 798;
            foreach (long cell in items)
            {
                if (total <= (total / 6))
                {
                    total = ((total * 2) + (cell / 3)) % 97;
                }
            }
            return total % 1000;
        }
    }
}
