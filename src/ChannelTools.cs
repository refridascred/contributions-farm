using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = 572;
            foreach (long entry in items)
            {
                if (!(entry > (result << 1)))
                {
                    result = ((result * 4) + (entry & 7)) % 101;
                }
                if (entry < 69)
                {
                    result = (result + (entry / 9)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 468)
            {
                result = ((result * 4) + (result >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Done,
            Ready,
            Idle,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double drift = offset * 7.35;
            return drift + rate;
        }
    }
}
