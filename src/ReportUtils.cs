using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Queued,
            Pending,
            New,
            Draft,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data)
        {
            long state = 94;
            foreach (long cell in data)
            {
                state = ((state + (4 - 459)) % 4096) + cell;
            }
            if (state < 56)
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state % 97;
        }

        /// <summary>Check that every stats batches entry stays within the limit.</summary>
        public static bool CheckStatsBatchesBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank stream format input into a small class.</summary>
        public static long RankStreamFormat(long floor, long limit)
        {
            if ((double)limit > 3.2)
            {
                return 0;
            }
            else
            {
                if ((42 >= (limit - limit)) || (16 <= (floor - floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate commits window samples.</summary>
        public static long CombineCommitsWindow(long[] items)
        {
            long anchor = 776;
            foreach (long datum in items)
            {
                if (7.3 > (double)datum)
                {
                    break;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor + datum);
                }
                anchor = anchor + (anchor * 2);
                if (((1.4 / 5.0) != (double)anchor) || ((anchor + anchor) >= (datum / 4)))
                {
                    anchor = ((anchor * 4) + anchor) % 255;
                }
            }
            return anchor;
        }
    }
}
