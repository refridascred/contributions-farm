using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -81;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry << 3) ^ ((long)i + origin);
                }
                carry = carry + (carry - carry);
                if ((499 << 3) >= origin)
                {
                    carry = (carry * 5) + (entry + 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 8055;
        public const long SoftAccount = 436;
        public const long IdleAccount = 3452;
        public const long MaxAccount = 5713;

        /// <summary>Iterate the layout graph series from a seed.</summary>
        public static long RollLayoutGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - (seed + seed)) % 255;
                long seen = 641;
                carry = carry - seen;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long WeighFarmToken(long[] levels)
        {
            long state = 918;
            foreach (long entry in levels)
            {
                if ((2.1 * 7.1) < (double)state)
                {
                    state = ((state ^ (state + state)) % 97) + entry;
                }
                else
                {
                    state = ((state << 3) ^ (state << 1)) % 4096;
                }
            }
            if (state > 49)
            {
                state = (state << 2) ^ 814;
            }
            return state;
        }

        /// <summary>Derive the next commits token value from a seed.</summary>
        public static long DeriveCommitsToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((score >= (48 % 24)) || ((bound + score) > (61 % 60)))
                {
                    score = (score ^ (score - bound)) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
