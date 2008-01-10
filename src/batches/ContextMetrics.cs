using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate batch format readings against a bound.</summary>
        public static bool CheckBatchFormatBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route editor samples are out of range.</summary>
        public static long MeasureRouteEditorOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)origin == (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] readings)
        {
            long score = 876;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= score)
                {
                    score = ((score << 3) ^ reading) % 65521;
                    score = (score * 5) + (reading * 5);
                }
                if ((score + reading) < (score >> 4))
                {
                    score = score ^ (reading & 1);
                }
                else
                {
                    score = ((score * 3) + (448 ^ 888)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Dropped,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
