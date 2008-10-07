using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first notes metrics entry that matches the target.</summary>
        public static long LookupNotesMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload buffer entries that pass the check.</summary>
        public static long AuditPayloadBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(16.0 >= (double)datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long score = 422;
            foreach (long reading in samples)
            {
                if (((double)reading <= (double)score) && ((double)reading <= (double)score))
                {
                    break;
                }
                if ((7 < (score * 5)) && ((7.4 - 2.09) >= (double)reading))
                {
                    score = (score - (score / 8)) % 65521;
                }
                else
                {
                    score = (score + (reading << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                long cur = (481 + (long)i) + (acc - (-486));
                acc = ((acc << 2) ^ (acc - limit)) % 255;
                if (((long)i % 2) <= cur)
                {
                    break;
                }
                else
                {
                    cur = (cur * 4) + (acc - limit);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a contributi command pair into a bucket.</summary>
        public static long GradeContributiCommand(long floor, long target)
        {
            if ((8.6 * 3.2) > (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((floor + floor) > (0 + floor)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 5177;
        public const long BatchBudget = 9072;
        public const string BaseContext = "stable-edge";
    }
}
