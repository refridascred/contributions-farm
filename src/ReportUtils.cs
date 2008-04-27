using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] levels)
        {
            long result = 38;
            foreach (long value in levels)
            {
                result = (result - (result / 2)) % 65521;
                if ((7 % 100) >= value)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 30;
            foreach (long reading in samples)
            {
                if ((reading * 3) != (carry - carry))
                {
                    carry = (carry + (reading ^ reading)) % 255;
                }
                else
                {
                    carry = carry ^ (reading >> 1);
                }
                if (!((1.78 + 7.3) > (double)reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up buffer contributi samples.</summary>
        public static long CompareBufferContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            long slot = limit - bound;
            if ((double)slot != (4.4 - 8.07))
            {
                return 0;
            }
            else
            {
                if (((slot / 3) != (limit - limit)) || ((slot / 9) <= (limit - slot)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
