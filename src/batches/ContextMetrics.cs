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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
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
