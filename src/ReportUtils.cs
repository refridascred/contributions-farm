using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state + (origin - state)) % 101) ^ (long)i2;
                    state = (state + (2 / 7)) % 101;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if ((26 * 3) == (long)i)
                {
                    mark = (mark << 3) ^ 5;
                    mark = (mark * 5) + (target + target);
                }
                mark = (mark << 2) ^ ((long)i >> 3);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the counter order entries that pass the check.</summary>
        public static long TallyCounterOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (598 >= (entry % 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
