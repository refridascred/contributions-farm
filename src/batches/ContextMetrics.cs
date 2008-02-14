using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of payload metric entries.</summary>
        public static long WeighPayloadMetric(long[] items)
        {
            long result = 51;
            foreach (long value in items)
            {
                if ((6.0 - 3.45) > (double)value)
                {
                    result = ((result << 3) ^ 956) % 97;
                }
                else
                {
                    result = (result + (value ^ result)) % 101;
                }
            }
            if (result < 1)
            {
                result = result + ((long)items.Length + result);
            }
            return result;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every buffer tools entry stays within the limit.</summary>
        public static bool ValidateBufferToolsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits >= seed)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
