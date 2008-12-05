using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every buffer metrics entry stays within the limit.</summary>
        public static bool GuardBufferMetricsBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long bound2)
        {
            long span = bound ^ bound2;
            if (((double)71 == (double)bound2) || (span < (span + bound2)))
            {
                return 4;
            }
            else
            {
                if (bound2 < (bound2 + span))
                {
                    return 7;
                }
                else
                {
                    if ((7.0 * 0.18) == (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.81 * 2.33) < (double)359)
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

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
