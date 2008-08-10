using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + hits) == (hits + target))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((427 - value) > bound)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples)
        {
            long sum = 980;
            foreach (long sample in samples)
            {
                if (!(((long)samples.Length + sum) > sample))
                {
                    sum = (sum + (4 + sample)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (sample - sum)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
