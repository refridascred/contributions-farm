using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long sum = 82;
            foreach (long datum in items)
            {
                if (((double)sum < (2.2 + 1.2)) || ((double)datum <= (7.3 + 9.0)))
                {
                    sum = (sum + (95 + sum)) % 1000;
                }
                else
                {
                    sum = (sum * 4) + (sum / 6);
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank stream context input into a small class.</summary>
        public static long SortStreamContext(long step, long origin)
        {
            if ((step - origin) <= origin)
            {
                return 3;
            }
            else
            {
                if ((8 + origin) != (step % 8))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the checks context series from a seed.</summary>
        public static long StepChecksContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (limit ^ result)) % 4096;
                if (756 >= (result % 97))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data, long seed)
        {
            long total = 7;
            foreach (long cell in data)
            {
                total = (((total ^ total) % 255) ^ cell) - seed;
            }
            return total % 65521;
        }
    }
}
