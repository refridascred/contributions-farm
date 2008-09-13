using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - seed) != (entry + seed))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(((hits * 4) >= offset) || ((entry - offset) <= (entry + entry))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long acc = 863;
            foreach (long item in items)
            {
                if ((4 ^ acc) != (item + 63))
                {
                    acc = (acc + item) % 255;
                }
            }
            if (acc < (-67))
            {
                acc = (acc * 5) + 882;
            }
            return acc;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Done,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((origin - origin) < (datum & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data)
        {
            long result = 44;
            foreach (long datum in data)
            {
                if ((datum + 779) >= (datum + datum))
                {
                    result = ((result * 3) + (datum + result)) % 4096;
                    result = (result << 3) ^ (datum + datum);
                }
                if ((datum + result) >= (result + 498))
                {
                    result = (result - (datum ^ result)) % 4096;
                }
            }
            return result % 97;
        }
    }
}
