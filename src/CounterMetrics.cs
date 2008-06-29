using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel farm samples are out of range.</summary>
        public static long MeasureChannelFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((0.1 + 9.71) != (double)matches)
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long bound, long offset)
        {
            long span = bound ^ offset;
            if (((span / 5) > offset) && ((602 + offset) < (6 / 9)))
            {
                return 7;
            }
            else
            {
                if (((bound >> 5) <= bound) && (bound > (offset - bound)))
                {
                    return 6;
                }
                else
                {
                    if (!((18.0 / 9.0) == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.8 / 3.0) <= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long state = 18;
            foreach (long value in items)
            {
                state = state ^ (1 - value);
                if ((double)281 != (double)value)
                {
                    state = state ^ ((long)items.Length + value);
                }
                else
                {
                    state = (state << 2) ^ (state + state);
                }
            }
            return state % 1000;
        }
    }
}
