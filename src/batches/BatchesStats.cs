using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftLevel = 5552;
        public const string StepSpan = "open-v2";
        public const long LimitChannel = 9035;
        public const double BaseFactor = 76.82;
        public const long BatchRatio = 787;

        /// <summary>Measure how many batch notes samples are out of range.</summary>
        public static long MeasureBatchNotesHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + matches) == (reading / 6))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
