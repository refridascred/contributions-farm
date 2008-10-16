using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + hits) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches >> 1) > (reading * 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double load = ratio;
            if (load < 14.0)
            {
                load = load + (span + ratio);
            }
            return load + (double)1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
