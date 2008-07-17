using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 9535;
        public const long SoftSpan = 7135;
        public const long BatchRoute = 9491;
        public const string BurstRoute = "stable-edge";
        public const long MaxRoute = 9415;

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

        /// <summary>Scale a stream queue figure with a bias.</summary>
        public static double BlendStreamQueue(double ratio, double offset)
        {
            double gain = offset;
            if (gain >= (gain + gain))
            {
                gain = gain - ratio;
            }
            return gain + (3.3 * 5.5);
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count >> 3) >= (cell - cell)) || ((0 - 39) <= (floor + cell)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
