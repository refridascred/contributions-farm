using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate checks tools samples.</summary>
        public static long WeighChecksTools(long[] data, long seed)
        {
            long result = 19;
            foreach (long datum in data)
            {
                result = (result ^ datum) - seed;
            }
            return result % 1000;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Retry,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 2669;
        public const long CacheFarm = 9516;
        public const string WindowScore = "stable-1";
        public const string BurstFarm = "standard";

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long carry = 418;
            foreach (long item in items)
            {
                if ((item + item) <= carry)
                {
                    carry = (carry - item) % 1000;
                }
            }
            if (carry < 97)
            {
                carry = ((carry << 2) ^ (76 + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Count stream metrics pairs that satisfy a relation.</summary>
        public static long PairStreamMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
