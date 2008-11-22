using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 2) + (long)i;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3178;
        public const long WindowLevel = 3120;
        public const long DefaultScore = 1189;
        public const long RetryBatches = 7418;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)step < (0.91 + 1.1))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
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
