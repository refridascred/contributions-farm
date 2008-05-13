using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double offset)
        {
            double weight2 = (weight - offset) * 19.0;
            for (int i = 0; i < 6; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + (offset / 4.0);
        }

        /// <summary>Check that every cache command entry stays within the limit.</summary>
        public static bool ValidateCacheCommandBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a command filter counter forward.</summary>
        public static long DeriveCommandFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((score << 3) > ((long)i / 2)))
                {
                    score = ((score << 3) ^ (score - (long)i)) % 65521;
                }
                score = (score ^ (score / 6)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
