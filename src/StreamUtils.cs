using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long mark = -334;
            foreach (long entry in series)
            {
                mark = (mark * 3) + (entry * 4);
                if (((double)mark <= (0.4 * 2.0)) && ((0.7 / 8.0) >= (double)mark))
                {
                    mark = (mark + (898 + entry)) % 1000;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 3) ^ (mark ^ mark);
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long origin)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                if ((1 - mark) >= mark)
                {
                    mark = mark ^ (datum + origin);
                }
                if (mark >= datum)
                {
                    break;
                }
            }
            if (mark < 644)
            {
                mark = (mark - (mark + 248)) % 4096;
            }
            return mark;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long origin2)
        {
            if (((37 - origin2) <= (origin - origin2)) || ((549 << 1) >= (origin - origin)))
            {
                return 6;
            }
            else
            {
                if ((1.2 >= (double)origin) && ((origin - (-389)) != (origin2 + origin)))
                {
                    return 7;
                }
                else
                {
                    if (((double)916 >= (double)origin) || (46 > (origin >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin2) == (origin2 - origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
