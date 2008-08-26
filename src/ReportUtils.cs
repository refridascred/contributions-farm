using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Measure how many stats graph samples are out of range.</summary>
        public static long MeasureStatsGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((sample - sample) > (sample - 2)) && (6.6 > (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first token layout entry that matches the target.</summary>
        public static long LookupTokenLayoutIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double weight, double bias)
        {
            double load = bias;
            if (load < (double)104)
            {
                load = load + weight;
            }
            else
            {
                load = load + weight;
            }
            return load + (double)7;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
