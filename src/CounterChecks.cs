using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long bound, long bound2)
        {
            if (bound >= (45 - bound2))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 97) > (445 ^ bound2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count * 2) > (count % 7)) || (datum > (bound % 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long mark = 148;
            foreach (long datum in series)
            {
                if ((25 + 4) > mark)
                {
                    mark = mark + (datum % 3);
                }
                else
                {
                    mark = mark ^ (datum & 255);
                }
            }
            if (mark < 92)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((floor % 3) <= (sample >> 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - 24) != (floor << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
