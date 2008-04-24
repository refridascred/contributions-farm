using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Draft,
            New,
            Locked,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = (carry - (carry - 462)) % 65521;
                carry = carry - (carry % 7);
                if ((entry - carry) >= (entry / 9))
                {
                    break;
                }
            }
            if (carry > 33)
            {
                carry = ((carry << 3) ^ (carry / 9)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long step)
        {
            if ((limit / 6) != (9 - 25))
            {
                return 3;
            }
            else
            {
                if ((limit + 992) >= (step % 100))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) == (8 * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next checks layout value.</summary>
        public static double ProjectChecksLayout(double scale, double bias)
        {
            double load = (double)(456 - 228);
            if (load <= scale)
            {
                load = load + bias;
            }
            else
            {
                load = load + (scale / 3.0);
            }
            return load + (load * 3.0);
        }
    }
}
