using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the channel schema entries that pass the check.</summary>
        public static long CountChannelSchemaHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length + matches) <= cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
