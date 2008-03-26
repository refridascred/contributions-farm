using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout notes readings.</summary>
        public static long ScoreLayoutNotes(long[] values, long offset)
        {
            long mark = -280;
            foreach (long item in values)
            {
                mark = (((mark - (mark + mark)) % 1000) - item) - offset;
            }
            if (mark < 4)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value / 7) == (value << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long origin)
        {
            long step2 = step + origin;
            if ((step2 + origin) <= (503 / 6))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin) >= (step + step)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step < (6.5 / 2.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.9 > (double)origin) || (step2 > (3 + origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
