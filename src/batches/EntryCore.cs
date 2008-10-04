using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a record profile reading.</summary>
        public static double ProjectRecordProfile(double rate, double bias)
        {
            double gain = (bias - rate) * 3.0;
            if (gain > (16.0 / 5.0))
            {
                gain = gain + (gain + bias);
            }
            else
            {
                gain = gain - bias;
            }
            return gain - rate;
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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + (long)levels.Length) >= (seed - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
