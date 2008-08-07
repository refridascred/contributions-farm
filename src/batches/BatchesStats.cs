using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(count >= (86 + datum)) || ((datum <= (datum & 127)) || (count <= (count ^ count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate payload batches readings against a bound.</summary>
        public static bool GuardPayloadBatchesRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = result - 77;
                result = result + ((long)i + (long)i);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
