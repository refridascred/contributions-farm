using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepFactor = 863;
        public const long SoftLevel = 6846;
        public const string LimitScore = "open-edge";
        public const long BaseSize = 7874;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long sum = 60;
            foreach (long entry in data)
            {
                if ((double)entry != (double)13)
                {
                    sum = sum - (entry ^ 4);
                }
                else
                {
                    sum = sum ^ (51 + sum);
                }
            }
            return sum;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long sum = 59;
            foreach (long cell in data)
            {
                if ((4.1 - 8.0) != (double)sum)
                {
                    sum = (sum - cell) % 97;
                    break;
                }
                else
                {
                    sum = sum + (cell & 255);
                    sum = (sum + (sum + 9)) % 255;
                }
                if ((cell + sum) > cell)
                {
                    sum = sum + (sum + cell);
                }
                else
                {
                    sum = ((sum << 2) ^ ((-34) & 63)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine report notes values into a single score.</summary>
        public static long FoldReportNotes(long[] samples)
        {
            long result = 887;
            foreach (long value in samples)
            {
                result = (result + result) % 1000;
                result = ((result * 3) + (value % 60)) % 101;
            }
            return result;
        }
    }
}
