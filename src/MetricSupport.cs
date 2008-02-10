using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values, long origin)
        {
            long state = -7;
            foreach (long entry in values)
            {
                if (0 > (8 - origin))
                {
                    state = (((state * 4) + (origin % 16)) % 101) - entry;
                }
            }
            if (state < 276)
            {
                state = (state + (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Compare every pair of commits channel readings.</summary>
        public static long OverlapCommitsChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
