using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long bound)
        {
            long edge = origin + bound;
            if (((5.4 + 4.0) == (double)origin) || ((6.0 * 14.0) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if ((origin + 9) <= (926 / 5))
                {
                    return 0;
                }
                else
                {
                    if ((41 & 7) <= (bound ^ edge))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset + offset) > ((long)data.Length - offset))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the payload report entries that pass the check.</summary>
        public static long CountPayloadReportOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.0 * 1.0) == (double)target)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
