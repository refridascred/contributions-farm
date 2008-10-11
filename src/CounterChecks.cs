using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - (mix + mix)) % 97;
                mix = (mix ^ (mix ^ mix)) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 910;
        public const long SoftRatio = 6253;
        public const double BatchEditor = 53.59;
        public const double StepEditor = 89.36;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 127) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long step)
        {
            long sum = -635;
            foreach (long item in data)
            {
                if ((94 % 60) <= (step + 4))
                {
                    sum = ((sum * 3) + (item % 97)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
