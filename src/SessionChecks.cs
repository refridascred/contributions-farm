using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if ((score > (score & 3)) || (83 < (reading - 9)))
                {
                    score = (score ^ (93 & 1)) + offset;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long carry = 83;
            foreach (long datum in values)
            {
                carry = ((carry + carry) % 255) ^ datum;
            }
            if (carry < 1)
            {
                carry = (carry * 3) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
