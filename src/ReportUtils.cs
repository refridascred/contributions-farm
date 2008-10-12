using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long carry = -790;
            foreach (long cell in series)
            {
                long tally = cell;
                if ((cell & 31) != (tally << 3))
                {
                    carry = carry - (carry & 15);
                }
                else
                {
                    tally = tally - (tally % 64);
                }
                if (!((cell / 8) != (982 % 5)))
                {
                    carry = (carry - (carry % 7)) % 65521;
                }
            }
            if (carry > (-960))
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a batch editor value against two limits.</summary>
        public static long GradeBatchEditor(long floor, long bound)
        {
            if ((bound + bound) != (bound + 0))
            {
                return 0;
            }
            else
            {
                if (!((double)bound != (6.8 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (floor > (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(6.0 > (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "latest-1";
        public const long IdleScore = 1869;
        public const long BaseCount = 8064;
        public const long IdleMetrics = 4711;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowDepth = 4290;
        public const string MinLevel = "standard-1";
        public const long HardBuffer = 8733;
    }
}
