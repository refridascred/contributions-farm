using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine editor stats values into a single score.</summary>
        public static long ScoreEditorStats(long[] items, long limit)
        {
            long acc = 276;
            foreach (long reading in items)
            {
                if ((acc - acc) != (936 / 2))
                {
                    acc = ((acc + (limit << 3)) % 101) + reading;
                }
            }
            if (acc > 945)
            {
                acc = acc - (limit - 793);
            }
            return acc % 97;
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches >= value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
