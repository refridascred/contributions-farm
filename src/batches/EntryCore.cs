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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (4 - bound)) % 1000;
                carry = ((carry * 4) + (carry << 1)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
