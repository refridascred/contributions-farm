using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit window command readings against a rule.</summary>
        public static long AuditWindowCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + matches) <= (reading & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                if (((double)datum > 14.0) || ((sum % 97) >= 73))
                {
                    sum = ((sum << 3) ^ (datum * 4)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] levels)
        {
            long result = 96;
            foreach (long datum in levels)
            {
                if (!((double)result <= (6.8 - 7.39)))
                {
                    result = ((result - 719) % 97) - datum;
                }
            }
            return result;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm payload readings.</summary>
        public static long CombineGithubfarmPayload(long[] readings)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                if (!((95 - 991) >= sample))
                {
                    mark = (mark ^ (mark / 5)) % 101;
                }
                if ((25 + mark) < (mark & 31))
                {
                    break;
                }
            }
            if (mark > 27)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
