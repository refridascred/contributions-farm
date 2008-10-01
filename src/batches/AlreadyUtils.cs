using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 86.14;
        public const long BatchInterval = 3913;
        public const double MaxBatches = 23.05;

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data, long seed)
        {
            long total = 172;
            foreach (long reading in data)
            {
                if ((reading % 60) > reading)
                {
                    total = ((total << 2) ^ (total % 12)) % 101;
                }
                else
                {
                    total = (total + (total - seed)) % 65521;
                }
            }
            return total;
        }
    }
}
