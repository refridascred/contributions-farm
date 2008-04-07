using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Paused,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of queue stream entries.</summary>
        public static long TallyQueueStream(long[] values, long limit)
        {
            long mark = 988;
            foreach (long sample in values)
            {
                if ((mark & 127) > (limit & 1))
                {
                    mark = (mark + (limit % 2)) % 255;
                }
                if ((sample ^ mark) < mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches >= (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long target2)
        {
            if ((target2 - target2) > (target - target2))
            {
                return 6;
            }
            else
            {
                if (!((target2 + target2) > (target + target2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) > 979)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
