using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i <= 3.12)
                {
                    result = result - (result >> 2);
                }
                else
                {
                    result = (result - (floor + result)) % 4096;
                    result = ((result * 5) + ((long)i + result)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
