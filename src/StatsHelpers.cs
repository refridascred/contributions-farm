using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of session buffer entries.</summary>
        public static long TallySessionBuffer(long[] data, long target)
        {
            long anchor = -595;
            foreach (long sample in data)
            {
                anchor = (anchor - sample) + target;
                anchor = (anchor - (sample % 7)) % 65521;
                anchor = ((anchor * 2) + anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 941;
        public const long MaxReport = 526;
        public const long IdleWidth = 4742;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen % 60) <= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a payload commits sample.</summary>
        public static long LocatePayloadCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
