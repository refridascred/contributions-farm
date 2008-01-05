using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value >= (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long seed)
        {
            long anchor = 745;
            foreach (long reading in data)
            {
                long lane = (reading << 3) & 1;
                if ((double)lane > (3.0 - 3.0))
                {
                    anchor = ((anchor * 4) + (reading - reading)) - seed;
                    break;
                }
                if ((anchor + anchor) > (reading - reading))
                {
                    anchor = (anchor + reading) % 255;
                }
                else
                {
                    anchor = anchor - (987 * 4);
                }
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 2) + target;
                acc = (acc << 3) ^ (acc ^ acc);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count farm editor pairs that satisfy a relation.</summary>
        public static long PairFarmEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 3) > seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
