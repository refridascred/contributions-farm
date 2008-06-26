using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Iterate the counter batch series from a seed.</summary>
        public static long IterateCounterBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up editor stats samples.</summary>
        public static long MatchEditorStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
