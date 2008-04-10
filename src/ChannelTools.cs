using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit route report readings against a rule.</summary>
        public static long CountRouteReportHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((double)(long)series.Length >= (2.0 - 7.3)) || (entry <= (tally + tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >> 4) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values)
        {
            long result = 68;
            foreach (long sample in values)
            {
                result = result + (sample >> 4);
            }
            return result;
        }
    }
}
