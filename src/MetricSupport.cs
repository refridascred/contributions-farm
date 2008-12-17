using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report graph values into a single score.</summary>
        public static long TallyReportGraph(long[] series, long floor)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if ((floor % 8) >= ((long)series.Length - floor))
                {
                    mark = ((mark + mark) % 4096) + entry;
                }
            }
            if (mark > 908)
            {
                mark = mark - (mark - (-40));
            }
            return mark;
        }

        /// <summary>Match up route notes samples.</summary>
        public static long MatchRouteNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long bound)
        {
            long anchor = -9;
            foreach (long reading in series)
            {
                anchor = ((anchor + anchor) % 1000) + reading;
            }
            if (anchor < 1)
            {
                anchor = (anchor + bound) % 4096;
            }
            return anchor % 4096;
        }
    }
}
