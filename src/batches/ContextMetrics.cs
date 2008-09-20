using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Audit batches support readings against a rule.</summary>
        public static long CountBatchesSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length - (-926)) <= (reading * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double ratio = (double)((-99) - 993);
            if (ratio <= (gain - gain))
            {
                ratio = (ratio + 14.0) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((58 + tally) < (48 << 2))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
