using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((double)hits <= (double)seed))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double rate2 = (rate / 9.0) - (3.02 * 8.4);
            return (rate2 + rate) + offset;
        }
    }
}
