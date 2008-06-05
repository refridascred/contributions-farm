using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (4 ^ origin)) % 65521;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count contributi commits pairs that satisfy a relation.</summary>
        public static long MatchContributiCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double mean = (scale - scale) + (bias / 4.0);
            if (mean < mean)
            {
                mean = mean + (double)35;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (5.2 / 9.0)) - (double)(long)i;
            }
            return mean + (double)2;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(((long)series.Length >> 5) < (bound % 12)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
