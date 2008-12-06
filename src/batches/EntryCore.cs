using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitDepth = 6230;
        public const long BaseAccount = 4811;
        public const long WindowCount = 6246;
        public const string MaxAccount = "cached-v2";
        public const double WindowAccount = 92.52;

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
