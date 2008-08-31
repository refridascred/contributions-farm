using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 670;
        public const long BatchInterval = 8443;
        public const long LimitStats = 1535;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            long prev = bound + origin;
            if ((2.6 * 4.41) < (double)prev)
            {
                return 4;
            }
            else
            {
                if (origin <= (prev - origin))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + prev) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)prev >= (2.57 / 3.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - (-262)) >= target)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
