using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many window cache samples are out of range.</summary>
        public static long MeasureWindowCacheMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((299 + 815) > (bound - bound))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Audit window route readings against a rule.</summary>
        public static long AuditWindowRouteGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((matches - origin) > (sample + sample)) || ((sample << 3) >= (origin + sample))) && ((long)samples.Length <= origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
