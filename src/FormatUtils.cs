using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 99;
            foreach (long value in readings)
            {
                total = total ^ value;
                if ((total * 2) > (value % 3))
                {
                    total = total - (value >> 5);
                }
            }
            return total;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate report context readings against a bound.</summary>
        public static bool CheckReportContextRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3341;
        public const double DefaultWidth = 0.15;
        public const string DefaultNotes = "latest-edge";
        public const double MinNotes = 31.32;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Active,
            Queued,
        }

        /// <summary>Look up the position of a cache payload sample.</summary>
        public static long LocateCachePayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
