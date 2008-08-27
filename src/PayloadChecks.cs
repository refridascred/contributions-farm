using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "stable";
        public const string DefaultFactor = "open-1";
        public const long StepRatio = 254;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long limit)
        {
            if ((offset < (limit & 127)) && ((10.0 - 2.5) != (double)limit))
            {
                return 5;
            }
            else
            {
                if (!((4 ^ offset) == (offset >> 1)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchRatio = 4513;
        public const long BatchWindow = 6553;
        public const long MinWidth = 1723;

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((target << 1) > count) && (((161 - (-62)) != (73 - datum)) && ((target / 4) <= target)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
