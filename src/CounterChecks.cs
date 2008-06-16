using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "cached-v2";
        public const long BaseScore = 6166;
        public const long BurstLayout = 6036;
        public const long RetrySize = 6830;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (step + (long)i)) % 101;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (sum ^ sum)) % 4096;
                if (!(((long)i * 2) <= ((long)i - sum)))
                {
                    sum = (sum + (bound & 1)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
