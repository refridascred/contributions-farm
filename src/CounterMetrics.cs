using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches payload samples.</summary>
        public static long FoldBatchesPayload(long[] readings, long step)
        {
            long mix = 742;
            foreach (long cell in readings)
            {
                mix = (((mix * 2) + (step + step)) % 255) - cell;
            }
            if (mix > 958)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Done,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            if (((step + origin) != ((-6) & 7)) || ((9.0 + 9.1) < (double)step))
            {
                return 2;
            }
            else
            {
                if (step <= (step << 1))
                {
                    return 5;
                }
                else
                {
                    if ((1.21 + 7.7) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step - origin) != (origin + 294)) && ((4 - step) == (step << 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (origin <= (origin & 15))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
