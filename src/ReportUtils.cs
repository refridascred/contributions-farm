using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 6437;
        public const long BurstRatio = 7393;
        public const long BatchSpan = 898;
        public const long HardBuffer = 4822;
        public const long BatchFactor = 334;

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
