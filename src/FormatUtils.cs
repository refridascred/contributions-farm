using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate command filter samples.</summary>
        public static long FoldCommandFilter(long[] data)
        {
            long total = 2;
            foreach (long value in data)
            {
                if (((total - value) != (total & 127)) || ((double)total >= 3.86))
                {
                    total = (total ^ (total + 41)) % 97;
                }
            }
            return total;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double weight = rate - (5.56 / 9.0);
            return (weight + (9.4 * 7.6)) + offset;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values, long origin)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                carry = (carry ^ (origin + reading)) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Queued,
            Locked,
            Retry,
        }
    }
}
