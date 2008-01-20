using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a notes window value against two limits.</summary>
        public static long ClassifyNotesWindow(long bound, long seed)
        {
            if ((bound - bound) >= (bound >> 5))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) >= (bound % 5))
                {
                    return 7;
                }
                else
                {
                    if (!(1 > (seed % 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (4.61 * 4.7)) + (double)(long)i) - weight;
            }
            return drift + (drift + bias);
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ carry) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
