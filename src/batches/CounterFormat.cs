using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ score;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Pending,
            Paused,
        }

        /// <summary>Look up the position of a editor commits sample.</summary>
        public static long LookupEditorCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
