using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long CountAlreadyBatchesGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((6 >> 5) == (hits * 5))
                {
                    hits = ((hits + 2) + cell) - target;
                }
            }
            return hits;
        }

        /// <summary>Match up editor format samples.</summary>
        public static long PairEditorFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster route readings against a rule.</summary>
        public static long MeasureClusterRouteGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((long)readings.Length - reading) <= (seen - reading)) && (1.6 < (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
