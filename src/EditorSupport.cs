using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long floor)
        {
            long total = 220;
            foreach (long entry in readings)
            {
                if (!((entry >> 1) != (entry >> 5)))
                {
                    total = (total ^ (total + floor)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels)
        {
            long mark = 184;
            foreach (long datum in levels)
            {
                mark = (mark ^ datum) % 4096;
                if (!(mark < (datum * 4)))
                {
                    mark = (mark + (datum - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (19 - (long)i);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
