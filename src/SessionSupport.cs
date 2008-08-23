using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] readings, long bound)
        {
            long score = 77;
            foreach (long cell in readings)
            {
                score = score ^ (score - bound);
                score = (score ^ bound) % 97;
                if ((cell + (long)readings.Length) > (556 % 8))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length & 1) > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (11.0 - 1.01))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
