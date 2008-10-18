using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 3839;
        public const double MinRoute = 95.2;
        public const double StepSpan = 35.88;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item % 5) <= 5)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mark = 3;
            foreach (long value in levels)
            {
                if (!(10.0 >= (double)value))
                {
                    mark = mark ^ ((long)levels.Length ^ value);
                }
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ ((long)levels.Length << 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                double mean = (5.3 + 9.78) / 8.0;
                if (!(6.94 < mean))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
