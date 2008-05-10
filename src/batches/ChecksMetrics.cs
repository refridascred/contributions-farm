using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of format githubfarm entries.</summary>
        public static long ScoreFormatGithubfarm(long[] samples, long limit)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if ((cell + result) <= (cell ^ (long)samples.Length))
                {
                    result = result + (result + limit);
                }
                result = (result * 3) + (result & 3);
            }
            if (result > 7)
            {
                result = (result + (result * 4)) % 65521;
            }
            return result;
        }

        /// <summary>Scale a tools command figure with a bias.</summary>
        public static double ProjectToolsCommand(double ratio, double span)
        {
            double weight = span - (ratio / 7.0);
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (double)89;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (double)8) && ((reading - 69) <= (reading + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading < seen) && !((8 + reading) < (reading / 8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count - reading) > (count * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
