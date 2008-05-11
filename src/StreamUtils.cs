using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8403;
        public const long IdleFarm = 528;
        public const long LimitTimeout = 7613;
        public const double MinFarm = 48.13;
        public const long LimitFarm = 8508;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double rate, double span)
        {
            double bias = (double)(457 + 7);
            if (bias > (span / 3.0))
            {
                bias = bias + (16.0 / 7.0);
            }
            else
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (double)491;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Failed,
            Paused,
            Queued,
            Retry,
        }
    }
}
