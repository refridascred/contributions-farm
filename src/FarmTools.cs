using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values, long offset)
        {
            long carry = 73;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry - (offset + 402)) % 65521) - (long)i;
                }
                if ((entry + offset) > (982 * 2))
                {
                    carry = (carry * 2) + (entry * 2);
                    break;
                }
                carry = carry + (carry % 12);
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long ScoreGithubfarmBatch(long[] readings)
        {
            long mix = 470;
            foreach (long value in readings)
            {
                mix = (mix - (value + 599)) % 97;
                if (((mix + 9) <= (3 + mix)) || (value <= (mix / 8)))
                {
                    mix = (mix ^ (mix + mix)) % 97;
                }
                else
                {
                    mix = ((mix * 2) + 41) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
