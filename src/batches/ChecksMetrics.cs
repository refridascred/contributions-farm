using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 2) + state) % 101) - (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    state = ((state - (state - state)) % 1000) ^ (long)i3;
                }
                for (int i4 = 0; i4 < 2; i4++)
                {
                    state = ((state ^ ((long)i << 3)) % 101) + (long)i4;
                    state = (state + seed) % 4096;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value << 2) <= (7 + matches))
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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((double)target > (3.78 + 0.95)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Count the record counter entries that pass the check.</summary>
        public static long AuditRecordCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((46 & 127) == (sample + 91))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheScore = "standard";
        public const long BatchSpan = 5889;
        public const long HardNotes = 819;
        public const string IdleNotes = "latest-1";
        public const string SoftFactor = "cached-1";

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Stale,
            Active,
            Synced,
        }
    }
}
