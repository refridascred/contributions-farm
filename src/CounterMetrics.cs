using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up order buffer samples.</summary>
        public static long MatchOrderBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next profile editor value.</summary>
        public static double SmoothProfileEditor(double gain, double offset)
        {
            double drift = gain;
            if (drift >= (9.0 / 5.0))
            {
                drift = (drift + gain) + offset;
            }
            return drift + drift;
        }

        /// <summary>Validate stream record readings against a bound.</summary>
        public static bool ValidateStreamRecordRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((diff + bound) < (diff - 1))
            {
                return 6;
            }
            else
            {
                if (bound >= (diff - bound))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
