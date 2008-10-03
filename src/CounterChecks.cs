using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit tools stream readings against a rule.</summary>
        public static long TallyToolsStreamHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((target - 2) < (datum << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 2735;
        public const long BaseGraph = 437;
        public const string WindowTimeout = "strict-edge";

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((69 <= (301 - bound)) && ((20.0 - 3.7) < (double)bound))
            {
                return 5;
            }
            else
            {
                if ((cur + bound) > (cur - (-243)))
                {
                    return 4;
                }
                else
                {
                    if ((cur - bound) <= (cur << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-18) ^ cur) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((9.4 - 6.7) <= (double)reading) && ((reading / 9) > ((-29) & 1)))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
