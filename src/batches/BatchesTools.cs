using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long target2)
        {
            if ((double)target < (14.0 * 13.0))
            {
                return 5;
            }
            else
            {
                if (((target2 + target2) > target) && ((18.0 + 5.6) != (double)target2))
                {
                    return 0;
                }
                else
                {
                    if ((target2 + target2) > (target2 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target2 >> 3) < (target2 * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
