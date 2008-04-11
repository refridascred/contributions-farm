using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double scale, double span)
        {
            double load = (double)70 / 3.0;
            if (load >= (double)(-56))
            {
                load = load + 1.4;
            }
            else
            {
                load = load + (scale + 16.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (span - scale);
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double scale = gain;
            if (scale <= (4.8 * 4.13))
            {
                scale = scale + gain;
            }
            return scale + offset;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long limit)
        {
            long total = 4;
            foreach (long sample in series)
            {
                if ((4.71 + 8.8) > (double)sample)
                {
                    total = (total ^ limit) % 4096;
                    total = ((total * 2) + total) % 1000;
                }
                if (!((total << 1) <= (54 - 69)))
                {
                    total = (total ^ (total ^ sample)) % 4096;
                }
            }
            if (total < 0)
            {
                total = (total - (limit + limit)) % 101;
            }
            return total;
        }
    }
}
