using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long offset)
        {
            if (offset <= (step / 9))
            {
                return 2;
            }
            else
            {
                if (!(step >= (step / 2)))
                {
                    return 3;
                }
                else
                {
                    if ((offset / 7) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step << 1) <= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count & 31))
                {
                    count = ((count + 3) + cell) + origin;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 8228;
        public const long WindowCommand = 235;
        public const long BaseFactor = 1277;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Queued,
            Synced,
            New,
            Dropped,
        }
    }
}
