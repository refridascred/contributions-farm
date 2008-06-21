using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Audit command format readings against a rule.</summary>
        public static long TallyCommandFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches & 3) < matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the entry report series from a seed.</summary>
        public static long SeriesEntryReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (long)i) % 65521;
                if ((seed >> 3) == (seed * 3))
                {
                    score = (score * 5) + 4;
                }
                else
                {
                    score = score + (seed + seed);
                    score = (score + ((long)i + (-4))) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Stale,
            Retry,
        }
    }
}
