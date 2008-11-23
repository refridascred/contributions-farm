using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSpan = "stable";
        public const long IdleInterval = 5958;
        public const long RetrySession = 1436;

        /// <summary>Combine commits order values into a single score.</summary>
        public static long DigestCommitsOrder(long[] values, long bound)
        {
            long mix = 475;
            foreach (long item in values)
            {
                mix = (((mix + (mix * 2)) % 65521) ^ item) + bound;
            }
            return mix % 97;
        }

        /// <summary>Audit channel command readings against a rule.</summary>
        public static long CountChannelCommandHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((offset >> 5) == (matches - 952))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long seed)
        {
            if ((floor - floor) > (floor + seed))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed + 557) != (seed << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor > (30 + seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a context route reading by value.</summary>
        public static long SeekContextRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
