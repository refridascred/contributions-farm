using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length > count)
                {
                    count = ((count + 2) ^ entry) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of already profile readings.</summary>
        public static long CompareAlreadyProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
