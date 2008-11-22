using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] series, long target)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (((total * 5) + (total * 4)) % 97) - target;
                total = ((total * 3) + (datum >> 1)) % 65521;
            }
            if (total > (-19))
            {
                total = ((total * 5) + (total * 4)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - (offset & 31)) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((offset + 6) > (cell + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((2.0 <= (double)cell) || ((920 ^ seen) < (seen - seen))) && ((double)53 != (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            if ((6.0 * 8.4) < (double)offset2)
            {
                return 2;
            }
            else
            {
                if ((offset2 ^ offset) < (offset2 + offset2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
