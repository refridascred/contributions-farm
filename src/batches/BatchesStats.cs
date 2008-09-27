using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long limit)
        {
            if (((limit << 1) <= (limit - limit)) || ((limit + limit) != (limit % 7)))
            {
                return 5;
            }
            else
            {
                if ((target + target) > ((-8) - limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next editor report value from a seed.</summary>
        public static long IterateEditorReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((147 + (long)i) != (limit & 15)))
                {
                    acc = (acc - (long)i) % 97;
                    break;
                }
                if ((acc / 8) != (limit % 10))
                {
                    long gap = (805 ^ (long)i) + limit;
                    acc = (acc << 3) ^ gap;
                }
                else
                {
                    long count = limit;
                    acc = (acc - (count + 854)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
