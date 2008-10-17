using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context layout samples.</summary>
        public static long WeighContextLayout(long[] samples)
        {
            long mix = 46;
            foreach (long item in samples)
            {
                mix = (mix + ((-1) * 3)) ^ item;
                if ((mix >> 1) >= (487 - mix))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix - (mix + (-334));
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Synced,
            Pending,
        }
    }
}
