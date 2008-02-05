using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= offset)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (weight / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - (double)863;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((9 - tally) < tally)
                {
                    tally = ((tally + 1) + value) - seed;
                }
            }
            return tally;
        }
    }
}
