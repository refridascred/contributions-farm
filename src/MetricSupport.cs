using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate order already samples.</summary>
        public static long DigestOrderAlready(long[] levels, long offset)
        {
            long anchor = 16;
            foreach (long datum in levels)
            {
                if ((double)0 >= (18.0 / 4.0))
                {
                    anchor = ((anchor << 2) ^ (-1)) % 4096;
                }
                if (((double)datum >= (7.24 / 3.0)) && (offset > (offset & 1)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Roll a context channel counter forward.</summary>
        public static long StepContextChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state << 3) ^ (state + state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit record metric readings against a rule.</summary>
        public static long MeasureRecordMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((114 + 2) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
