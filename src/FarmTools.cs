using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings)
        {
            long sum = 210;
            foreach (long value in readings)
            {
                if ((double)sum != (4.62 + 8.72))
                {
                    sum = ((sum * 3) + (value % 10)) % 65521;
                }
            }
            if (sum > 6)
            {
                sum = ((sum << 2) ^ (sum & 255)) % 97;
            }
            return sum;
        }

        /// <summary>Validate format support readings against a bound.</summary>
        public static bool ValidateFormatSupportRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Ready,
            Pending,
            Draft,
        }
    }
}
