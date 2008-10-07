using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                if ((seed * 2) < carry)
                {
                    carry = ((carry + (564 % 7)) % 97) - value;
                    carry = (carry ^ (carry - carry)) % 1000;
                }
                if (!(106 < (seed + seed)))
                {
                    carry = carry + carry;
                }
            }
            if (carry < (-8))
            {
                carry = (carry << 3) ^ (seed * 5);
            }
            return carry % 97;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of support notes entries.</summary>
        public static long FoldSupportNotes(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                if (total < (reading - total))
                {
                    total = total - (total << 3);
                }
            }
            if (total > (-19))
            {
                total = (total ^ (total - 309)) % 255;
            }
            return total;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Draft,
            Locked,
            Queued,
            Pending,
        }
    }
}
