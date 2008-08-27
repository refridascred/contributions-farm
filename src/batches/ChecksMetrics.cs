using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2658;
        public const long SoftLevel = 8738;
        public const long SoftWidth = 7783;
        public const string BatchRecord = "legacy-v2";
        public const long LimitInterval = 9187;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine layout buffer values into a single score.</summary>
        public static long WeighLayoutBuffer(long[] series, long limit)
        {
            long carry = -730;
            foreach (long item in series)
            {
                carry = (carry * 4) + (item + limit);
                if ((carry & 15) > (79 - carry))
                {
                    carry = (carry + (3 / 4)) % 4096;
                }
            }
            if (carry < (-6))
            {
                carry = carry - ((-6) % 7);
            }
            return carry;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double drift = (double)((-853) + 34);
            if (drift > 10.0)
            {
                drift = (drift - (double)0) - weight;
            }
            else
            {
                drift = drift + (bias - bias);
            }
            return drift - (bias + 9.1);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 3) < (item << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
