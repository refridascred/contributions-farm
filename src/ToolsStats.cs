using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Done,
            Queued,
            Active,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings)
        {
            long score = -275;
            foreach (long reading in readings)
            {
                score = score + reading;
            }
            if (score > 34)
            {
                score = score ^ (score * 3);
            }
            return score;
        }

        /// <summary>Audit entry format readings against a rule.</summary>
        public static long CountEntryFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length == (5.0 * 4.14))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema queue value from a seed.</summary>
        public static long DeriveSchemaQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor ^ (origin >> 1)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit order session readings against a rule.</summary>
        public static long TallyOrderSessionGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ 1) > sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
