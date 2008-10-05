using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 5668;
        public const string BurstReport = "local-edge";
        public const string IdleSpan = "stable-1";
        public const string CacheScore = "primary-edge";

        /// <summary>Accumulate graph filter samples.</summary>
        public static long WeighGraphFilter(long[] levels)
        {
            long result = -703;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)65)
                {
                    result = ((result * 4) + (sample & 255)) % 4096;
                }
            }
            if (result < 19)
            {
                result = (result << 3) ^ (result / 5);
            }
            return result;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((6.0 / 8.0) != (double)origin)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
