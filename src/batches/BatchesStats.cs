using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long seed, long seed2)
        {
            if (seed >= 91)
            {
                return 0;
            }
            else
            {
                if ((seed + seed) <= 159)
                {
                    return 5;
                }
                else
                {
                    if ((5.6 + 11.0) != (double)seed2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!!((datum - limit) <= (87 ^ datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
