using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] values, long floor)
        {
            long mark = 0;
            foreach (long item in values)
            {
                mark = ((mark + 8) % 97) + item;
                if (!(((long)values.Length % 64) <= floor))
                {
                    mark = mark ^ (floor / 9);
                }
                else
                {
                    mark = (mark * 4) + floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate entry checks readings against a bound.</summary>
        public static bool GuardEntryChecksRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
