using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long IterateSessionSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (sum < ((long)i >> 5))
                {
                    sum = ((sum * 2) + ((long)i - sum)) % 4096;
                }
                else
                {
                    sum = (sum * 5) + (sum * 4);
                }
                if (sum <= ((long)i << 1))
                {
                    sum = (sum * 4) + (sum & 255);
                    continue;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count batches payload pairs that satisfy a relation.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Draft,
            Pending,
            New,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheRatio = 26.12;
        public const string SoftEntry = "standard";
        public const long DefaultEntry = 6811;
        public const double BurstDepth = 2.02;
        public const double LimitEntry = 6.87;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
