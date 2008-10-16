using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] items)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                acc = (acc * 2) + 638;
                if ((reading - 39) != (3 - acc))
                {
                    acc = ((acc * 2) + (reading >> 5)) % 65521;
                }
            }
            return acc % 97;
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
