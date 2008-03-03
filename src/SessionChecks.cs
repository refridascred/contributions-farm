using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long target)
        {
            long total = 81;
            foreach (long cell in readings)
            {
                total = ((total * 5) + (195 / 7)) ^ cell;
                if ((double)target <= (1.34 * 8.71))
                {
                    total = (total - (total >> 5)) % 65521;
                }
                else
                {
                    total = (total + total) % 1000;
                }
            }
            if (total > 78)
            {
                total = (total - total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value < (value >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm channel samples.</summary>
        public static long TallyFarmChannel(long[] readings, long offset)
        {
            long score = 9;
            foreach (long entry in readings)
            {
                if (69 >= (score - entry))
                {
                    score = (((score << 2) ^ (score + 47)) % 97) - offset;
                }
                else
                {
                    score = (score << 3) ^ (entry & 255);
                }
            }
            return score % 4096;
        }
    }
}
