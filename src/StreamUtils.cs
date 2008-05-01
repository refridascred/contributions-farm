using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a batch counter reading.</summary>
        public static double ProjectBatchCounter(double ratio, double offset)
        {
            double gain = 7.8;
            if (gain >= (ratio - ratio))
            {
                gain = gain + 0.3;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + (gain / 2.0);
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
