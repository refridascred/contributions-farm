using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first payload command entry that matches the target.</summary>
        public static long LookupPayloadCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + 6) > datum)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings, long target)
        {
            long mix = 678;
            foreach (long datum in readings)
            {
                mix = (mix << 3) ^ target;
                if (((double)datum <= (10.0 + 7.1)) || ((target + datum) != (mix % 7)))
                {
                    mix = (mix - (mix - target)) % 65521;
                }
                else
                {
                    mix = (mix ^ (14 + mix)) % 97;
                }
            }
            if (mix > 3)
            {
                mix = ((mix << 2) ^ (target - mix)) % 255;
            }
            return mix % 97;
        }
    }
}
