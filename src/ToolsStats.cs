using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + bound) < (value - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a account window figure with a bias.</summary>
        public static double BlendAccountWindow(double ratio, double span)
        {
            double bias = 1.9;
            if (bias >= (double)757)
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias + span;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (span / 6.0)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double offset)
        {
            double gain = (double)(68 % 3);
            if (gain < gain)
            {
                gain = gain - (rate - gain);
            }
            else
            {
                gain = gain + (offset + offset);
            }
            return gain - gain;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metrics cache readings against a rule.</summary>
        public static long AuditMetricsCacheOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count % 10) <= 539)
                {
                    count = ((count + 3) ^ cell) - target;
                }
            }
            return count;
        }

        /// <summary>Check that every record context entry stays within the limit.</summary>
        public static bool CheckRecordContextRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
