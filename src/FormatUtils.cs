using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3619;
        public const long DefaultInterval = 513;
        public const long WindowLayout = 8699;
        public const double BatchRatio = 90.65;

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long seed)
        {
            long anchor = 942;
            foreach (long datum in items)
            {
                if (datum < (40 - datum))
                {
                    anchor = ((anchor * 2) + (seed + anchor)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Find the first context buffer entry that matches the target.</summary>
        public static long FindContextBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long origin, long floor)
        {
            if (((1.3 - 14.0) <= (double)origin) && ((floor + origin) <= origin))
            {
                return 7;
            }
            else
            {
                if ((double)floor > (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((628 + floor) <= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
