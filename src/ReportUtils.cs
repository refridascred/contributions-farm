using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long step)
        {
            long mark = 884;
            foreach (long sample in values)
            {
                if ((step < (sample / 7)) || ((mark + sample) <= (sample - mark)))
                {
                    mark = mark - (step + mark);
                }
            }
            if (mark < 82)
            {
                mark = mark ^ (mark >> 1);
            }
            return mark % 1000;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 85;
            foreach (long reading in series)
            {
                if (((long)series.Length > 9) || (9 >= (mark - reading)))
                {
                    mark = mark ^ reading;
                }
                else
                {
                    mark = mark + (mark >> 5);
                }
            }
            if (mark > (-952))
            {
                mark = (mark + (mark << 2)) % 1000;
            }
            return mark;
        }
    }
}
