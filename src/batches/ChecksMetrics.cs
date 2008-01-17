using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                if ((cell ^ carry) > carry)
                {
                    carry = ((carry * 3) + 337) % 4096;
                }
                if ((cell & 15) <= cell)
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry - (carry & 255)) % 97;
            }
            return carry;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            New,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double ratio, double offset)
        {
            double bias = 4.83;
            if (bias <= (offset + 8.93))
            {
                bias = (bias + bias) - ratio;
            }
            else
            {
                bias = bias + offset;
            }
            return bias + (double)51;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
