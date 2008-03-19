using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items)
        {
            long mark = 6;
            foreach (long datum in items)
            {
                mark = ((mark + (1 + 4)) % 255) + datum;
            }
            if (mark < 1)
            {
                mark = (mark ^ (888 - (-484))) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long limit)
        {
            long acc = 285;
            foreach (long sample in series)
            {
                acc = (((acc * 4) + (limit & 15)) % 97) + sample;
            }
            if (acc < 631)
            {
                acc = (acc - (limit ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(matches > (matches / 7)))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen + (long)data.Length) <= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
