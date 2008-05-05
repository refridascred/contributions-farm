using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Scale a entry checks figure with a bias.</summary>
        public static double ProjectEntryChecks(double bias, double bias2)
        {
            double ratio = bias2 / 4.0;
            if (ratio <= (bias2 / 2.0))
            {
                ratio = ratio - (bias - bias2);
            }
            else
            {
                ratio = ratio - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (double)56;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next contributi tools value from a seed.</summary>
        public static long DeriveContributiTools(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 2) ^ (step - result);
                if (step > result)
                {
                    result = result + step;
                }
                else
                {
                    result = (result - (89 << 1)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
