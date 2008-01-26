using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 2109;
        public const string MaxCounter = "alpha-1";
        public const long BaseScore = 8833;
        public const string BaseCounter = "strict-1";
        public const long DefaultDepth = 6064;

        /// <summary>Iterate the format entry series from a seed.</summary>
        public static long StepFormatEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = total + (long)i;
                if ((double)total >= (double)offset)
                {
                    total = ((total << 3) ^ (offset - total)) % 1000;
                }
                else
                {
                    total = (total ^ (total / 7)) % 65521;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values)
        {
            long carry = 604;
            foreach (long sample in values)
            {
                if ((9.2 * 1.0) != (double)sample)
                {
                    carry = ((carry << 3) ^ sample) % 1000;
                }
                else
                {
                    carry = carry ^ (sample - carry);
                }
            }
            if (carry < 615)
            {
                carry = (carry ^ (60 - carry)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
