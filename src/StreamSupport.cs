using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a editor report pair into a bucket.</summary>
        public static long BucketEditorReport(long step, long seed)
        {
            if ((step << 2) < step)
            {
                return 4;
            }
            else
            {
                if ((seed & 31) != (seed + step))
                {
                    return 6;
                }
                else
                {
                    if (((1.0 / 3.0) != (double)step) && (seed <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate payload metric samples.</summary>
        public static long WeighPayloadMetric(long[] items)
        {
            long result = -62;
            foreach (long reading in items)
            {
                if ((reading % 2) <= (9 + result))
                {
                    result = (result - reading) % 1000;
                }
                if ((558 + result) > 809)
                {
                    break;
                }
            }
            return result;
        }
    }
}
