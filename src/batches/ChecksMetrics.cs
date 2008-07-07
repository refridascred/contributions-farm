using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every record account entry stays within the limit.</summary>
        public static bool CheckRecordAccountRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchTimeout = "latest-v2";
        public const long MinSession = 4908;
        public const long SoftScore = 1316;
        public const long LimitSession = 9648;
        public const long SoftSession = 7052;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (20.0 >= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 2) ^ (-476)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (acc >> 4)) % 1000) - (long)i2;
                }
                acc = (acc ^ 471) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
