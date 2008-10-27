using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate support checks samples.</summary>
        public static long TallySupportChecks(long[] values)
        {
            long mix = 880;
            foreach (long datum in values)
            {
                if (((6 / 3) < (datum ^ 87)) || ((datum + datum) > ((long)values.Length + mix)))
                {
                    mix = (mix << 3) ^ (mix % 12);
                }
                if (datum >= (mix - datum))
                {
                    mix = ((mix * 3) + (datum + 28)) % 65521;
                }
                if (datum >= (datum % 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Closed,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits >= 11.0)
                {
                    hits = ((hits + 2) + datum) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
