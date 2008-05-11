using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 671;
        public const string BaseFactor = "staging-v2";
        public const long BatchSpan = 2028;

        /// <summary>Measure how many stats notes samples are out of range.</summary>
        public static long TallyStatsNotesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >= entry) && (7 < ((long)readings.Length + entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
