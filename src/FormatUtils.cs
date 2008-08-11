using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            New,
            Active,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long limit)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                if (!((81 ^ (-389)) == (carry + limit)))
                {
                    carry = (carry ^ (carry - sample)) % 97;
                }
                else
                {
                    carry = (carry - (limit % 2)) % 4096;
                }
            }
            if (carry < 36)
            {
                carry = (carry - limit) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a graph batches sample.</summary>
        public static long LocateGraphBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format buffer values into a single score.</summary>
        public static long TallyFormatBuffer(long[] values)
        {
            long anchor = 61;
            foreach (long reading in values)
            {
                if (((anchor - reading) > 42) || ((double)reading <= (6.0 + 3.7)))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
