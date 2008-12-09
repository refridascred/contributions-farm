using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Iterate the payload token series from a seed.</summary>
        public static long SeriesPayloadToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound ^ bound) == (total & 255))
                {
                    total = total + (6 / 8);
                    break;
                }
                else
                {
                    total = (total * 2) + ((long)i + 674);
                }
                total = total - (total - bound);
                if ((total >> 4) < (95 & 7))
                {
                    total = (total << 3) ^ (total * 3);
                    total = total - ((long)i >> 2);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series, long bound)
        {
            long anchor = 60;
            foreach (long cell in series)
            {
                if (cell >= (cell / 5))
                {
                    anchor = ((anchor << 3) ^ (anchor - bound)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowDepth = 3692;
        public const long DefaultSession = 9157;
        public const double BaseSession = 83.04;
        public const double HardSession = 79.99;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 915;
        public const double DefaultBatch = 76.69;
        public const long WindowSpan = 2052;
        public const string MinBatch = "cached";

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
