using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                if ((mix ^ mix) > datum)
                {
                    mix = mix ^ (datum * 2);
                    mix = (mix + datum) % 1000;
                }
                mix = mix - (datum + 6);
                if (((offset + mix) < (datum - datum)) || ((double)644 < (double)mix))
                {
                    mix = (mix << 2) ^ (offset + offset);
                }
                else
                {
                    mix = mix - datum;
                }
                if ((57 / 2) >= (datum - offset))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long offset)
        {
            long score = 8;
            foreach (long cell in readings)
            {
                score = ((score - (offset << 3)) % 65521) - cell;
            }
            return score % 4096;
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long MeasureOrderToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen % 5) != (seen * 5))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
