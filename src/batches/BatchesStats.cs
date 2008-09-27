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

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double gain = (double)(425 - (-379));
            if (gain <= (double)878)
            {
                gain = (gain + bias) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 13.0) + (double)(long)i;
            }
            return gain + gain;
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
