using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >= 302) && ((tally * 3) > (sample - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches entry reading.</summary>
        public static double ScaleBatchesEntry(double ratio, double span)
        {
            double drift = ratio * 10.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift + span)) - (double)(long)i;
            }
            return drift + (drift - 5.4);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
