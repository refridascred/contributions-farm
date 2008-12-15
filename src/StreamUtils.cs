using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading << 2) != (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry entry stays within the limit.</summary>
        public static bool GuardBatchesEntryLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels)
        {
            long mark = -9;
            foreach (long sample in levels)
            {
                mark = (mark << 3) ^ (long)levels.Length;
                if ((sample * 4) >= (sample + mark))
                {
                    break;
                }
            }
            if (mark < 81)
            {
                mark = ((mark << 2) ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (anchor - (anchor >> 5)) + (long)i2;
                }
                if (2 > origin)
                {
                    anchor = ((anchor << 2) ^ (origin % 3)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a commits checks value against two limits.</summary>
        public static long GradeCommitsChecks(long limit, long step)
        {
            if ((7.32 + 8.34) != (double)step)
            {
                return 2;
            }
            else
            {
                if ((double)step > (15.0 * 20.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
