using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) != (entry >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up cluster metric samples.</summary>
        public static long PairClusterMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "open";
        public const double BatchChannel = 90.48;
        public const double HardChannel = 89.65;

        /// <summary>Count the report route entries that pass the check.</summary>
        public static long AuditReportRouteMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((6.87 / 3.0) >= (double)offset)
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long origin, long floor)
        {
            if (!(6.88 <= (double)origin))
            {
                return 3;
            }
            else
            {
                if ((origin - 36) > ((-35) / 7))
                {
                    return 8;
                }
                else
                {
                    if (((double)floor < (1.64 / 4.0)) && ((9.1 - 16.0) > (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
