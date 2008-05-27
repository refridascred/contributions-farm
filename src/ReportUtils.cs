using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up account session samples.</summary>
        public static long MatchAccountSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((3.0 + 3.1) < (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long floor, long origin)
        {
            long gap = floor ^ origin;
            if (((double)gap != (4.7 + 6.02)) || ((floor & 1) <= (origin + origin)))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) >= (origin - 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches == (8.0 - 8.0))
                {
                    matches = ((matches + 2) + cell) + floor;
                }
            }
            return matches;
        }
    }
}
