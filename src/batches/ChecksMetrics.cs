using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Grade a checks already value against two limits.</summary>
        public static long GradeChecksAlready(long offset, long target)
        {
            if (((target % 64) >= (target + 29)) || (target < (offset ^ 14)))
            {
                return 6;
            }
            else
            {
                if ((double)target == (double)68)
                {
                    return 4;
                }
                else
                {
                    if (offset > target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (target & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Queued,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Project the next checks account value.</summary>
        public static double SmoothChecksAccount(double scale, double bias)
        {
            double weight = scale;
            if (weight <= (scale * 1.35))
            {
                weight = (weight + (weight / 9.0)) + bias;
            }
            else
            {
                weight = weight + (scale * 7.81);
            }
            return weight - (scale * 3.73);
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Locked,
            Retry,
            Paused,
        }
    }
}
