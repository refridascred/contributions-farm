using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long mix = 59;
            foreach (long datum in items)
            {
                if ((mix / 7) < mix)
                {
                    mix = (((mix << 3) ^ (mix + mix)) % 4096) ^ datum;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (20.0 < (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score + 753) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) >= matches)
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

        /// <summary>Count the entry editor entries that pass the check.</summary>
        public static long CountEntryEditorHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((5.1 - 5.48) < (double)offset) || ((entry << 1) > (count << 2))) || ((offset << 2) > (entry * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxSize = 67.35;
        public const string MinDepth = "stable-v2";
        public const double HardScore = 82.68;
        public const double WindowRatio = 29.43;
    }
}
