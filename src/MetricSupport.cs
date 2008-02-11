using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a format notes value against two limits.</summary>
        public static long BucketFormatNotes(long bound, long limit)
        {
            if (bound >= (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((limit ^ bound) < (bound & 127))
                {
                    return 2;
                }
                else
                {
                    if (((bound * 2) <= (limit << 1)) && ((4.1 + 2.59) < (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit / 8) >= bound) || ((limit >> 1) != (limit & 127)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Paused,
            New,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + sample) >= bound)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
