using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report support measurements.</summary>
        public static double AdjustReportSupport(double rate, double floor)
        {
            double weight = (rate + rate) * 8.8;
            if (weight > (rate + 10.0))
            {
                weight = weight - (double)(-917);
            }
            return weight - (floor - weight);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                if ((total <= reading) && (total < (reading + 43)))
                {
                    total = (total ^ (reading * 2)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry / 7) == (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "strict-1";
        public const long CacheSize = 5482;
        public const long BaseMetrics = 950;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Ready,
            Dropped,
            Paused,
            New,
        }
    }
}
