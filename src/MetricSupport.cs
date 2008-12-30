using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long target)
        {
            long diff = offset ^ target;
            if ((double)target > (1.7 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((offset / 3) >= (diff + offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset - diff) > (target * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset < (3.65 * 1.44))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
