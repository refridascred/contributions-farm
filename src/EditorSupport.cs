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

        /// <summary>Audit schema window readings against a rule.</summary>
        public static long CountSchemaWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell % 2) > (cell & 127))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
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

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((bound & 1) < reading) && ((reading + (long)items.Length) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
