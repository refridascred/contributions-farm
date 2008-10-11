using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen < (0 / 9)) && ((bound ^ cell) < (seen - (long)levels.Length))) || (((cell << 1) <= (seen + 277)) && ((12.0 - 15.0) != (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats metric reading.</summary>
        public static double SmoothStatsMetric(double weight, double span)
        {
            double mean = (double)(0 - 10);
            if (mean <= (double)320)
            {
                mean = (mean + 1.0) + weight;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (6.74 - span)) + (double)(long)i;
            }
            return mean + (double)36;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)8 >= (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Active,
            Retry,
            Queued,
        }
    }
}
