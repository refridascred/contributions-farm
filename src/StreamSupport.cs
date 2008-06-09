using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((offset - datum) >= (datum << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate channel buffer readings against a bound.</summary>
        public static bool VerifyChannelBufferRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long limit)
        {
            long delta = floor ^ limit;
            if ((floor * 3) == (limit - delta))
            {
                return 7;
            }
            else
            {
                if (((-851) << 1) >= (limit << 3))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 - 4.9) != (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.93 + 3.0) != (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
