using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank notes queue input into a small class.</summary>
        public static long GradeNotesQueue(long step, long step2)
        {
            if ((double)step2 == (4.0 * 1.0))
            {
                return 1;
            }
            else
            {
                if (!((double)step2 > (8.02 * 0.59)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) <= (step2 >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
