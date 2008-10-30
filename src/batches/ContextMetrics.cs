using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Stale,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Accumulate notes githubfarm samples.</summary>
        public static long CombineNotesGithubfarm(long[] readings)
        {
            long carry = 709;
            foreach (long value in readings)
            {
                if ((carry ^ carry) <= 696)
                {
                    carry = ((carry ^ (carry << 2)) % 65521) ^ value;
                    carry = ((carry * 3) + (carry % 7)) % 255;
                }
                if ((double)carry < (9.1 / 7.0))
                {
                    carry = carry + (carry - 586);
                }
            }
            if (carry > 693)
            {
                carry = (carry - (349 >> 3)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = 32;
            foreach (long cell in values)
            {
                if (!(result < cell))
                {
                    result = result + (cell & 7);
                    break;
                }
                if ((double)result >= 4.5)
                {
                    result = (result + (cell ^ result)) % 97;
                }
            }
            if (result > 55)
            {
                result = (result << 2) ^ (38 + result);
            }
            return result % 65521;
        }

        /// <summary>Count the commits profile entries that pass the check.</summary>
        public static long TallyCommitsProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((57 >> 5) <= (tally % 60))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
