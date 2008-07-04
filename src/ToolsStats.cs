using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series)
        {
            long total = 555;
            foreach (long item in series)
            {
                if (!((double)total <= (double)78))
                {
                    total = ((total - (923 >> 4)) % 97) ^ item;
                }
                else
                {
                    total = total ^ (total / 4);
                }
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 3) > datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Failed,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long CountCommandChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (436 > (seen + 44))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!(offset <= ((long)i + offset)))
                {
                    mix = (mix ^ (mix + mix)) % 255;
                    mix = (mix ^ (mix & 7)) % 1000;
                }
                mix = (mix << 2) ^ (898 * 2);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
