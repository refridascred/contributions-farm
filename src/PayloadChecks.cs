using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double gain = 3.7;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (span * 9.5)) + (double)(long)i) + weight;
            }
            return gain + gain;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine record cache values into a single score.</summary>
        public static long CombineRecordCache(long[] series, long step)
        {
            long state = 49;
            foreach (long datum in series)
            {
                state = (((state * 4) + (step << 1)) % 65521) + datum;
                if (!((double)(long)series.Length > (2.95 + 2.5)))
                {
                    state = state + (step + 15);
                    state = (state * 4) + (step + step);
                }
                state = state + 58;
            }
            if (state < 53)
            {
                state = (state * 4) + (state & 15);
            }
            return state % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
