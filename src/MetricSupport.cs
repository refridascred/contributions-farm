using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a editor payload figure with a bias.</summary>
        public static double SmoothEditorPayload(double ratio, double span)
        {
            double scale = (double)(93 + 4);
            if (scale <= span)
            {
                scale = scale - (ratio + span);
            }
            return scale + ratio;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) > (5 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
