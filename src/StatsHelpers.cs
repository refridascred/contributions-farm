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

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
