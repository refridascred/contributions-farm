using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up commits cache samples.</summary>
        public static long CompareCommitsCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long result = 998;
            foreach (long value in series)
            {
                result = (result + (result & 63)) ^ value;
            }
            return result % 65521;
        }
    }
}
