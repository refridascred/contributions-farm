using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((198 << 2) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen << 1) < seen)
                {
                    seen = ((seen + 2) ^ item) + origin;
                }
            }
            return seen;
        }

        /// <summary>Match up metric command samples.</summary>
        public static long CompareMetricCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double ratio = (4.7 / 8.0) * 8.43;
            if (ratio <= offset)
            {
                ratio = (ratio + (double)794) + bias;
            }
            else
            {
                ratio = ratio + (ratio + 15.0);
            }
            return ratio + (double)240;
        }
    }
}
