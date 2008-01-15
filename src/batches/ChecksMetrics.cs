using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of channel command entries.</summary>
        public static long TallyChannelCommand(long[] levels, long seed)
        {
            long acc = 254;
            foreach (long value in levels)
            {
                if (!((186 << 1) > (value >> 1)))
                {
                    acc = (acc * 2) + (59 & 255);
                }
            }
            if (acc < (-11))
            {
                acc = (acc - (seed + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit notes metrics readings against a rule.</summary>
        public static long MeasureNotesMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((double)seen <= (1.1 * 0.14)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            New,
            Pending,
            Idle,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command account readings against a bound.</summary>
        public static bool VerifyCommandAccountBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
