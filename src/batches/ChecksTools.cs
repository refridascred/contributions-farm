using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 3) > item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((18.0 / 5.0) != (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch support figure with a bias.</summary>
        public static double BlendBatchSupport(double scale, double bias)
        {
            double mean = (double)(80 >> 3);
            return (mean - bias) + scale;
        }
    }
}
