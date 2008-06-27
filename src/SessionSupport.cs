using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((matches - matches) != (entry + 346)) && ((entry + entry) >= ((long)series.Length + matches))) || ((matches + matches) < entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - datum) > (tally + 883))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
