using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long carry = 47;
            foreach (long reading in items)
            {
                carry = ((carry * 3) + reading) % 1000;
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry - (2 - carry)) ^ (long)i;
                }
                if ((reading & 3) <= (reading + reading))
                {
                    carry = (carry + carry) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of order support entries.</summary>
        public static long DigestOrderSupport(long[] values)
        {
            long sum = 49;
            foreach (long datum in values)
            {
                if (!((datum * 5) >= (sum & 3)))
                {
                    sum = ((sum << 2) ^ (datum % 100)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every already format entry stays within the limit.</summary>
        public static bool CheckAlreadyFormatRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
