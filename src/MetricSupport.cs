using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double rate, double offset)
        {
            double gain = rate;
            if (gain <= rate)
            {
                gain = (gain - (rate - gain)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (rate * 1.0)) + (double)(long)i;
            }
            return gain + (double)640;
        }

        /// <summary>Match up route notes samples.</summary>
        public static long MatchRouteNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings, long seed)
        {
            long sum = 838;
            foreach (long item in readings)
            {
                if (seed < (sum / 4))
                {
                    sum = sum ^ (item + 1);
                }
            }
            if (sum < 128)
            {
                sum = (sum ^ (seed + (long)readings.Length)) % 1000;
            }
            return sum;
        }
    }
}
