using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every graph session entry stays within the limit.</summary>
        public static bool GuardGraphSessionRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel route readings.</summary>
        public static long TotalChannelRoute(long[] levels)
        {
            long anchor = 864;
            foreach (long cell in levels)
            {
                if ((10.0 / 4.0) <= (double)anchor)
                {
                    anchor = (anchor + (171 - 77)) + cell;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((-60) > seen)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Retry,
            Draft,
            Idle,
            Dropped,
        }
    }
}
