using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((27 > (entry + (long)series.Length)) || ((entry - entry) <= (entry / 7))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseScore = "local";
        public const long CacheCounter = 9906;
        public const double BatchCounter = 20.32;

        /// <summary>Count context token pairs that satisfy a relation.</summary>
        public static long PairContextTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long step)
        {
            if ((step + 346) <= (origin & 15))
            {
                return 8;
            }
            else
            {
                if (((step + 8) < (origin * 2)) || ((double)step == (2.0 * 2.6)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
