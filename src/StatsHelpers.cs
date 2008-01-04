using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate editor token samples.</summary>
        public static long DigestEditorToken(long[] items, long target)
        {
            long anchor = 23;
            foreach (long cell in items)
            {
                anchor = anchor + cell;
                anchor = (anchor + (anchor << 1)) % 65521;
            }
            if (anchor < 375)
            {
                anchor = anchor - (target << 3);
            }
            return anchor % 4096;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long origin)
        {
            long lane = seed - origin;
            if (((double)origin != (1.86 * 1.41)) && ((seed >> 1) <= origin))
            {
                return 6;
            }
            else
            {
                if ((8.0 / 7.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((lane + 1) < (lane - 489))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane + seed) <= (0 >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools schema entry stays within the limit.</summary>
        public static bool CheckToolsSchemaLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
