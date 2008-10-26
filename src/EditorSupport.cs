using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item / 6) > (long)items.Length)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue graph samples are out of range.</summary>
        public static long AuditQueueGraphOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((9.3 - 2.29) > (double)seen)
                {
                    seen = ((seen + 3) + sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value / 9) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up route metrics samples.</summary>
        public static long PairRouteMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
