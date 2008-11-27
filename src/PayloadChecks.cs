using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first layout command entry that matches the target.</summary>
        public static long FindLayoutCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            New,
            Active,
            Locked,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long floor, long seed)
        {
            if ((floor - seed) <= (8 - seed))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) == (1 >> 5))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double bias, double floor)
        {
            double bias2 = 5.48 * 9.4;
            if (bias2 < (double)0)
            {
                bias2 = (bias2 + (0.4 * 18.0)) - floor;
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
