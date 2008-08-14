using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long CountSchemaReportHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((4.39 - 13.0) > (double)matches))
                {
                    matches = ((matches + 2) ^ reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!!((matches % 64) != ((long)levels.Length + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                long gap = (result ^ (long)i) & 63;
                if ((gap + gap) < result)
                {
                    result = (result ^ (gap & 3)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ (bound * 4)) % 255;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
