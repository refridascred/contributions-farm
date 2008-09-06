using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Stale,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((49 ^ item) >= item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                long diff = ((long)i - bound) / 8;
                if (((long)i / 5) >= diff)
                {
                    result = result - 5;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a metrics batch counter forward.</summary>
        public static long StepMetricsBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + ((long)i - step);
                mix = ((mix << 2) ^ step) % 255;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
