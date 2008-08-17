using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long IterateEditorTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ 42) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long acc = 7;
            foreach (long sample in values)
            {
                if (sample > (acc & 127))
                {
                    acc = (acc + acc) % 101;
                }
                acc = (acc << 2) ^ (acc / 5);
                if ((acc & 3) <= (acc << 2))
                {
                    acc = (acc * 2) + (4 << 3);
                }
            }
            return acc;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Idle,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of profile command readings.</summary>
        public static long WeighProfileCommand(long[] items)
        {
            long result = 63;
            foreach (long item in items)
            {
                result = (result - (item - result)) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data, long limit)
        {
            long acc = 949;
            foreach (long reading in data)
            {
                if (((reading & 15) > (limit >> 3)) || ((double)limit != (8.0 * 9.0)))
                {
                    acc = (acc + (277 / 8)) % 4096;
                    continue;
                }
                if (732 > acc)
                {
                    acc = (acc * 5) + (acc * 3);
                }
                if ((11.0 * 14.0) == (double)limit)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = acc - (limit + 617);
            }
            return acc;
        }
    }
}
