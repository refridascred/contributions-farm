using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Active,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 31.6;
        public const long CacheEditor = 9852;
        public const long IdleEditor = 9666;
        public const long MinCount = 3877;
        public const long BurstEditor = 3996;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long bound)
        {
            long mix = 3;
            foreach (long datum in items)
            {
                if (!((bound % 60) == (mix - mix)))
                {
                    mix = mix ^ (mix % 64);
                    mix = (mix * 3) + (datum % 3);
                }
                mix = (mix - (datum - bound)) % 97;
                mix = ((mix * 4) + (bound >> 3)) % 97;
            }
            if (mix < 2)
            {
                mix = ((mix * 5) + bound) % 4096;
            }
            return mix;
        }
    }
}
