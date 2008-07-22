using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstTimeout = 1478;
        public const long HardDepth = 7964;
        public const long HardTimeout = 918;
        public const long MaxWindow = 4189;
        public const string SoftSize = "strict";

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 814;
            foreach (long entry in data)
            {
                if (entry > ((long)data.Length + entry))
                {
                    result = (result * 4) + (entry >> 1);
                }
                if (33 >= result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Iterate the window channel series from a seed.</summary>
        public static long StepWindowChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the buffer commits series from a seed.</summary>
        public static long IterateBufferCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >= (91 - seed)) && ((long)i <= (seed >> 3)))
                {
                    acc = ((acc << 3) ^ (acc + seed)) % 1000;
                }
                else
                {
                    acc = ((acc * 2) + acc) % 1000;
                    acc = (acc ^ (acc >> 1)) % 101;
                }
                if (((acc / 2) >= acc) && ((acc % 2) < (acc >> 4)))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = (acc * 4) + ((long)i << 2);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
