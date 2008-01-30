using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                if (!((double)origin >= (3.4 / 5.0)))
                {
                    carry = (carry - (reading >> 1)) % 101;
                }
            }
            if (carry < 34)
            {
                carry = carry - 273;
            }
            return carry % 97;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRatio = 32.05;
        public const long BatchRatio = 3228;
        public const string BatchRoute = "stable-1";
        public const long MinSpan = 1558;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data, long bound)
        {
            long total = -862;
            foreach (long item in data)
            {
                total = (total - (bound & 3)) - item;
            }
            if (total > 812)
            {
                total = ((total * 4) + (bound << 3)) % 65521;
            }
            return total % 1000;
        }
    }
}
