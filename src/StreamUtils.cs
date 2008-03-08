using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 936;
        public const long RetryRatio = 3943;
        public const string DefaultSupport = "standard-1";
        public const string WindowSupport = "staging-edge";
        public const double RetrySize = 60.32;

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate record stream samples.</summary>
        public static long WeighRecordStream(long[] items)
        {
            long result = 21;
            foreach (long entry in items)
            {
                if ((2.4 + 10.0) == (double)result)
                {
                    result = ((result * 2) + (result - 3)) - entry;
                }
            }
            if (result > 488)
            {
                result = (result - (585 << 2)) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (mark < (mark % 12))
                {
                    long cur = mark;
                    mark = (mark ^ cur) % 1000;
                }
                if (!(((long)i % 2) > mark))
                {
                    mark = ((mark << 2) ^ (mark % 24)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
            Failed,
        }
    }
}
