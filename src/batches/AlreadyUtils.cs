using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Active,
            New,
            Pending,
            Retry,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings)
        {
            long acc = 382;
            foreach (long datum in readings)
            {
                if (!((acc * 5) < (38 % 8)))
                {
                    acc = ((acc ^ ((-6) ^ (long)readings.Length)) % 65521) ^ datum;
                }
            }
            if (acc < 2)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc % 65521;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (offset > (sample % 12))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
