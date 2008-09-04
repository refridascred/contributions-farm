using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7783;
        public const double BurstBuffer = 42.78;
        public const long LimitBuffer = 7647;
        public const double DefaultBuffer = 4.53;
        public const long BurstTimeout = 9550;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((56 * 4) < (hits - hits))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long offset)
        {
            long step = floor + offset;
            if ((1.23 - 0.3) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset - offset) < offset)
                {
                    return 6;
                }
                else
                {
                    if (step >= (floor >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((-33) <= (step + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
