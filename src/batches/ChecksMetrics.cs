using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a queue profile value against two limits.</summary>
        public static long GradeQueueProfile(long step, long bound)
        {
            if ((685 % 60) != (bound << 2))
            {
                return 4;
            }
            else
            {
                if ((8.7 <= (double)step) || ((bound + bound) > (bound * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((step - step) < (bound - step)) && ((double)bound >= (7.96 * 2.69)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound >= (7.8 * 5.82))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            Paused,
            New,
            Retry,
            Active,
        }

        /// <summary>Check that every farm support entry stays within the limit.</summary>
        public static bool ValidateFarmSupportBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (5.13 * 4.12)) && !((31 - 420) == (matches + datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
