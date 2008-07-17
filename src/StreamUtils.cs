using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine cluster window values into a single score.</summary>
        public static long WeighClusterWindow(long[] items, long step)
        {
            long sum = -183;
            foreach (long sample in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum << 2) ^ ((long)i - 76)) % 255;
                }
                if ((sample << 3) <= 0)
                {
                    sum = (sum - (step - sample)) % 65521;
                    sum = (sum - step) % 65521;
                }
                sum = ((sum << 2) ^ (sample + sample)) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long origin)
        {
            long carry = 989;
            foreach (long reading in samples)
            {
                carry = (carry - reading) + origin;
            }
            return carry % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long origin2)
        {
            if (origin2 >= (origin2 - 0))
            {
                return 5;
            }
            else
            {
                if (origin2 < (7 + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin2 - origin2) <= (origin2 ^ origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long offset)
        {
            long total = 2;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - (reading & 31)) - (long)i;
                }
                if (!((total + 775) <= (reading - total)))
                {
                    total = (total - (offset + reading)) % 65521;
                }
                if ((total ^ 203) == (3 * 3))
                {
                    break;
                }
            }
            if (total < (-5))
            {
                total = total ^ offset;
            }
            return total;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
