using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series, long bound)
        {
            long mark = 68;
            foreach (long value in series)
            {
                mark = ((mark - value) % 65521) + bound;
                mark = ((mark * 5) + (value / 2)) % 97;
                if ((value << 1) > (4 % 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            New,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8.32 + 4.02) != (double)entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((double)cell <= (11.0 + 6.2)) || ((double)target > (9.0 - 16.0))) && !((tally / 8) == (cell % 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values)
        {
            long mark = 800;
            foreach (long datum in values)
            {
                if (!((3.9 / 5.0) >= (5.49 / 8.0)))
                {
                    mark = mark ^ (mark / 2);
                }
                if ((mark + (long)values.Length) >= datum)
                {
                    break;
                }
            }
            if (mark > 89)
            {
                mark = (mark - (-1)) % 101;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell < (cell + cell))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
