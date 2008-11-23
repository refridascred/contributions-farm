using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long GradeEntryFilter(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if (7.31 <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (((bound2 ^ 77) >= (bound & 3)) || (1.91 <= (double)bound2))
                {
                    return 7;
                }
                else
                {
                    if ((2.84 - 9.36) >= (double)bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound < (double)bound2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) < offset)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
