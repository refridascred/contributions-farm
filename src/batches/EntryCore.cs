using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many already entry samples are out of range.</summary>
        public static long TallyAlreadyEntryGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) > (cell ^ 733))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long mix = 6;
            foreach (long datum in values)
            {
                mix = ((mix * 5) + (mix & 3)) % 101;
                mix = mix + 18;
                if (((mix >> 4) >= datum) || ((double)datum > (4.0 * 3.0)))
                {
                    mix = mix - (mix + mix);
                }
            }
            return mix;
        }

        /// <summary>Validate buffer metrics readings against a bound.</summary>
        public static bool CheckBufferMetricsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
