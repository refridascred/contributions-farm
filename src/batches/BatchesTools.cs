using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a account graph value against two limits.</summary>
        public static long SortAccountGraph(long floor, long target)
        {
            if ((480 % 97) > floor)
            {
                return 1;
            }
            else
            {
                if (!((floor + floor) < ((-1) + target)))
                {
                    return 5;
                }
                else
                {
                    if (61 <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.03 - 1.27) >= (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
