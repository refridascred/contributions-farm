using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long target, long target2)
        {
            long span = target ^ target2;
            if (((target2 + target2) < (target2 + target)) && ((span ^ span) != (672 + target2)))
            {
                return 4;
            }
            else
            {
                if ((double)span <= (9.0 * 7.5))
                {
                    return 8;
                }
                else
                {
                    if ((target2 + span) <= (span ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSpan = 2329;
        public const long BurstOrder = 8604;
        public const long HardOrder = 1348;
    }
}
