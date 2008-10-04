using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items)
        {
            long anchor = -6;
            foreach (long item in items)
            {
                if ((anchor - item) == (anchor + anchor))
                {
                    anchor = (anchor ^ (anchor - item)) % 101;
                }
                else
                {
                    anchor = anchor + item;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "local";
        public const long SoftRatio = 8900;
        public const long DefaultQueue = 8403;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate cluster farm samples.</summary>
        public static long DigestClusterFarm(long[] levels)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if (entry >= (carry * 3))
                {
                    carry = (carry - (entry & 3)) % 255;
                }
            }
            if (carry > 16)
            {
                carry = ((carry * 2) + carry) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
