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

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
