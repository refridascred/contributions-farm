using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long offset)
        {
            long carry = -985;
            foreach (long reading in data)
            {
                if (((offset + 74) <= offset) && ((carry + offset) > (-627)))
                {
                    carry = (carry + (carry >> 2)) ^ reading;
                }
                else
                {
                    carry = (carry * 3) + (28 - offset);
                }
            }
            if (carry < 8)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((seed & 1) >= seed)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue record readings.</summary>
        public static long TotalQueueRecord(long[] levels, long seed)
        {
            long anchor = 682;
            foreach (long reading in levels)
            {
                anchor = anchor ^ (anchor >> 4);
                anchor = anchor - (reading - 63);
                anchor = (anchor + (anchor / 9)) % 255;
            }
            if (anchor < 44)
            {
                anchor = anchor + seed;
            }
            return anchor;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Closed,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 2804;
        public const long HardCommits = 2412;
        public const double SoftRatio = 33.93;
    }
}
