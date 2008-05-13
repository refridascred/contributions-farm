using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long step)
        {
            long total = 56;
            foreach (long item in series)
            {
                total = ((total + ((long)series.Length + item)) % 1000) + step;
                total = (total << 3) ^ (total & 63);
                if (!((total * 5) < total))
                {
                    total = (total ^ (item ^ 561)) % 65521;
                }
                else
                {
                    total = (total + total) % 255;
                }
            }
            return total;
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
