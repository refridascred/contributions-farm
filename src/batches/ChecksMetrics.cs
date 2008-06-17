using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Audit report account readings against a rule.</summary>
        public static long MeasureReportAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((-6) + (long)samples.Length) <= tally) || ((double)value < (8.5 + 9.1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((score * 5) < score)
                {
                    score = ((score * 4) + (limit + (long)i)) % 255;
                    score = score + ((long)i << 2);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((2.0 + 12.0) >= (double)hits) || (target < (item + 5))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream report figure with a bias.</summary>
        public static double SmoothStreamReport(double scale, double offset)
        {
            double mean = scale / 5.0;
            if (mean < (0.2 + offset))
            {
                mean = mean - (offset + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + (9.38 * 7.4);
        }
    }
}
