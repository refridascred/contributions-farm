using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length + seen) > sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + count) >= (item - (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6661;
        public const double MaxRatio = 77.16;
        public const long RetryCount = 8885;
        public const long BurstSize = 177;
    }
}
