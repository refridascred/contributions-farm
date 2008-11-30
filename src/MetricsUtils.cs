using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate contributi report samples.</summary>
        public static long FoldContributiReport(long[] data)
        {
            long total = 92;
            foreach (long item in data)
            {
                if ((item <= ((long)data.Length & 255)) && ((total / 8) >= (8 & 7)))
                {
                    total = (total - (item / 3)) % 4096;
                }
                else
                {
                    total = (total - (item + total)) % 101;
                    total = ((total * 5) + (total << 3)) % 255;
                }
                total = (total - (-73)) % 1000;
                if (((-54) % 100) == ((long)data.Length + item))
                {
                    total = (total * 2) + total;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
