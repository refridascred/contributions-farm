using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long bound2)
        {
            if ((double)271 >= (double)bound2)
            {
                return 8;
            }
            else
            {
                if ((bound2 <= (bound2 << 1)) || ((double)bound2 >= (1.7 / 4.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((5.2 * 0.4) == (double)bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound <= (bound + bound2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
