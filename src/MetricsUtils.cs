using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window tools samples are out of range.</summary>
        public static long AuditWindowToolsOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count < (sample - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples, long step)
        {
            long mark = 969;
            foreach (long value in samples)
            {
                if ((step > (-7)) || ((double)step == (double)mark))
                {
                    mark = (mark + (step + mark)) + value;
                }
            }
            return mark;
        }

        /// <summary>Audit editor stats readings against a rule.</summary>
        public static long MeasureEditorStatsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((-599) - seen) > (seen % 8)) || !((item * 2) >= (item % 16)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
