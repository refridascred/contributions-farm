using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two batches payload measurements.</summary>
        public static double ScaleBatchesPayload(double rate, double bias)
        {
            double load = bias;
            if (load < (rate * 9.3))
            {
                load = load - (double)787;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - rate) - (double)(long)i;
            }
            return load - 20.0;
        }

        /// <summary>Classify a buffer command pair into a bucket.</summary>
        public static long ClassifyBufferCommand(long offset, long seed)
        {
            if ((seed << 1) == (offset + 16))
            {
                return 8;
            }
            else
            {
                if (!((seed + offset) > 34))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (offset * 5)) || ((16.0 * 3.0) > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < (5 & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((194 & 63) >= (item << 2))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 3) < ((-1) * 5))
                {
                    matches = ((matches + 2) + cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Retry,
            Closed,
            New,
            Synced,
        }
    }
}
