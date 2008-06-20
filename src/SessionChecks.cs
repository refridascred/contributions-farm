using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - (scale / 6.0);
        }

        /// <summary>Derive the next commits session value from a seed.</summary>
        public static long IterateCommitsSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of order token entries.</summary>
        public static long TotalOrderToken(long[] series, long step)
        {
            long carry = -537;
            foreach (long reading in series)
            {
                carry = ((carry << 3) ^ 5) % 65521;
                if (((6 - reading) == (carry - 556)) || ((carry / 4) != (carry + reading)))
                {
                    carry = carry - (4 << 2);
                }
                if ((-792) > (step - carry))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
