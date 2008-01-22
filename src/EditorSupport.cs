using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long origin)
        {
            long mark = 32;
            foreach (long item in samples)
            {
                mark = (((mark << 2) ^ (origin + mark)) % 101) + item;
            }
            return mark;
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 7538;
        public const long SoftStats = 1841;
        public const string RetryStats = "legacy-edge";
        public const double StepStats = 6.61;
        public const string MaxSize = "cached-v2";

        /// <summary>Look up the position of a tools queue sample.</summary>
        public static long LookupToolsQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
