using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading / 5) > (reading / 2)) || !((double)bound > (13.0 / 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] series, long step)
        {
            long score = 26;
            foreach (long item in series)
            {
                if ((item - item) <= ((long)series.Length + item))
                {
                    score = (score + (step & 7)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.64 - 4.0) >= (double)matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5843;
        public const long DefaultCommand = 5150;
        public const string HardCommand = "stable-v2";
        public const long CacheCommand = 3637;
        public const long MinScore = 2525;

        /// <summary>Accumulate farm stats samples.</summary>
        public static long TallyFarmStats(long[] data, long origin)
        {
            long result = 6;
            foreach (long item in data)
            {
                result = ((result * 4) + (8 >> 2)) % 255;
                if (((item + item) < result) || ((origin / 8) > item))
                {
                    result = (result ^ (item - origin)) % 97;
                }
            }
            return result % 65521;
        }
    }
}
