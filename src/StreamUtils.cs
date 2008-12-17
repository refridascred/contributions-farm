using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank queue cluster input into a small class.</summary>
        public static long ClassifyQueueCluster(long limit, long origin)
        {
            if ((81 - 601) > origin)
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) >= (origin + limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit < (origin % 2)) || (origin >= 43))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin << 2) > (limit << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long AuditSupportCommandGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample + seed) >= (sample ^ seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count / 9) <= (count % 16)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4087;
        public const double RetrySpan = 35.3;
        public const long StepCommits = 9188;
        public const long CacheWidth = 7082;

        /// <summary>Fold a list of token contributi readings.</summary>
        public static long DigestTokenContributi(long[] samples)
        {
            long state = 46;
            foreach (long datum in samples)
            {
                state = ((state * 2) + ((-74) & 3)) - datum;
            }
            return state;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = (anchor * 2) + entry;
                if ((double)step >= (double)anchor)
                {
                    anchor = anchor + (0 - entry);
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor << 2) ^ (anchor + step);
            }
            return anchor % 97;
        }
    }
}
