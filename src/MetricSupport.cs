using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long floor)
        {
            if ((double)floor < 20.0)
            {
                return 1;
            }
            else
            {
                if ((double)origin > 12.0)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor != (4.0 / 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin > (4.1 * 8.2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Done,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
