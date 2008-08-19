using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((floor > ((long)i ^ anchor)) && ((24 << 3) <= (anchor << 1))))
                {
                    anchor = ((anchor << 3) ^ (48 - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate account graph readings against a bound.</summary>
        public static bool ValidateAccountGraphBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long origin, long target)
        {
            long delta = origin + target;
            if ((double)delta >= (0.2 - 3.7))
            {
                return 4;
            }
            else
            {
                if ((target * 2) != (target / 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((sample + matches) == (30 & 127)) && ((double)sample > (double)771)) && (sample > ((-36) % 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
