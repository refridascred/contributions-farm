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

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] values)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                if (!((double)(-289) <= (double)sample))
                {
                    anchor = (anchor - (0 * 5)) % 255;
                }
            }
            return anchor % 4096;
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
