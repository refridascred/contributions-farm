using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) >= (cell & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a editor command reading.</summary>
        public static double BlendEditorCommand(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (mean / 4.0))
            {
                mean = (mean - 11.0) - gain;
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + (double)3;
        }
    }
}
