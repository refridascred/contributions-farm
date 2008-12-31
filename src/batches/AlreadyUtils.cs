using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count context counter pairs that satisfy a relation.</summary>
        public static long MatchContextCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double bias, double span)
        {
            double load = (double)31 + (double)256;
            if (load <= load)
            {
                load = ((load + load) + bias) - span;
            }
            return load + 11.0;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long step)
        {
            long sum = -1;
            foreach (long value in values)
            {
                if ((4.8 / 9.0) < (double)sum)
                {
                    sum = (sum << 3) ^ (value >> 5);
                }
                else
                {
                    sum = (sum * 3) + (sum + step);
                }
            }
            if (sum > (-55))
            {
                sum = ((sum << 3) ^ (step + sum)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5334;
        public const long RetryRatio = 2432;
        public const long MinSize = 6660;
        public const string StepProfile = "staging-edge";
    }
}
