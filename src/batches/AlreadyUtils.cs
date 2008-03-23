using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2357;
        public const double MaxReport = 95.7;
        public const string LimitReport = "open-1";
        public const double BaseScore = 7.74;
        public const string BurstWidth = "staging-edge";

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long anchor = 31;
            foreach (long cell in values)
            {
                if ((anchor ^ anchor) <= cell)
                {
                    anchor = anchor ^ (cell * 4);
                }
                else
                {
                    anchor = anchor ^ (8 >> 3);
                }
                if ((6.65 / 9.0) == (double)(long)values.Length)
                {
                    anchor = (anchor - (anchor ^ anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (cell << 1)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxWidth = 82.48;
        public const long SoftSize = 2703;
        public const long StepCommits = 3505;

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster buffer value from a seed.</summary>
        public static long DeriveClusterBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
