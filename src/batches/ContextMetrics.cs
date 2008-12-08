using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((9.42 / 2.0) > (double)seed)
                {
                    mix = (mix * 5) + mix;
                    mix = (mix ^ (25 % 16)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((6 * 5) < (hits << 2))
                {
                    hits = (hits + 3) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long state = 977;
            foreach (long item in readings)
            {
                if ((item * 4) > state)
                {
                    state = ((state * 4) + (item / 4)) % 97;
                }
            }
            if (state > 3)
            {
                state = state + (state / 6);
            }
            return state;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Draft,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Find the first contributi metrics entry that matches the target.</summary>
        public static long FindContributiMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
