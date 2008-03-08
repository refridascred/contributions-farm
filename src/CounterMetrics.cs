using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of payload editor entries.</summary>
        public static long DigestPayloadEditor(long[] readings, long offset)
        {
            long result = -66;
            foreach (long value in readings)
            {
                result = (result - (value - result)) + offset;
            }
            return result;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultScore = 2189;
        public const long SoftSchema = 7735;
        public const string IdleScore = "local-1";
        public const long MinSchema = 6390;
        public const long IdleSchema = 5898;
    }
}
