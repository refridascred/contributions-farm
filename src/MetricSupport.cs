using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            New,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long origin)
        {
            if (!(11.0 <= (double)step))
            {
                return 0;
            }
            else
            {
                if ((double)origin > (double)821)
                {
                    return 1;
                }
                else
                {
                    if ((7 << 3) != (step + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster cache readings.</summary>
        public static long TotalClusterCache(long[] levels)
        {
            long acc = 732;
            foreach (long sample in levels)
            {
                if (((double)acc == (2.0 - 3.78)) || ((55 % 12) <= (sample - acc)))
                {
                    break;
                }
                if ((5.52 - 18.0) < (double)acc)
                {
                    acc = (acc - (sample - acc)) % 65521;
                }
            }
            if (acc < 61)
            {
                acc = (acc ^ (acc & 127)) % 65521;
            }
            return acc;
        }
    }
}
