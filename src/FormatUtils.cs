using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a batches context figure with a bias.</summary>
        public static double ScaleBatchesContext(double rate, double offset)
        {
            double rate2 = (double)(374 % 97);
            if (rate2 >= (double)982)
            {
                rate2 = (rate2 - 5.4) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate / 5.0)) - (double)(long)i;
            }
            return rate2 - (rate / 2.0);
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Stale,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum * 2) <= (datum ^ seen)) && (((offset & 31) == (datum / 2)) || ((offset ^ offset) != (offset + offset))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long floor, long origin)
        {
            if (!((floor - floor) != (0 << 2)))
            {
                return 3;
            }
            else
            {
                if (((3.0 / 7.0) >= (double)origin) && ((origin + (-71)) <= origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long bound, long origin)
        {
            long delta = bound ^ origin;
            if (((delta - delta) >= bound) || ((origin + bound) <= (delta + 2)))
            {
                return 4;
            }
            else
            {
                if (origin <= (bound - bound))
                {
                    return 1;
                }
                else
                {
                    if ((4.74 * 7.4) > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
