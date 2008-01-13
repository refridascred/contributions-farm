using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate cluster batches readings against a bound.</summary>
        public static bool GuardClusterBatchesBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
