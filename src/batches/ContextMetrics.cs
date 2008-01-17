using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every entry route entry stays within the limit.</summary>
        public static bool GuardEntryRouteLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((896 ^ value) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream cluster readings.</summary>
        public static long DigestStreamCluster(long[] readings, long limit)
        {
            long anchor = 573;
            foreach (long reading in readings)
            {
                anchor = ((anchor * 2) + (anchor << 2)) % 1000;
                if (((reading + reading) >= (anchor & 127)) || (limit >= (reading & 255)))
                {
                    anchor = (anchor ^ limit) % 4096;
                }
            }
            return anchor % 65521;
        }
    }
}
