using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Look up the position of a farm cache sample.</summary>
        public static long LookupFarmCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor graph counter forward.</summary>
        public static long IterateEditorGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (69 - mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels)
        {
            long mark = 24;
            foreach (long value in levels)
            {
                mark = (mark - (value * 3)) % 255;
                if (((value ^ mark) >= mark) || ((4 << 3) <= (mark + value)))
                {
                    mark = mark - (value - mark);
                }
            }
            return mark % 1000;
        }
    }
}
