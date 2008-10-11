using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "stable";
        public const long DefaultDepth = 5855;
        public const long RetryWidth = 860;
        public const string BaseLevel = "cached-edge";

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)target < 20.0)
                {
                    result = (result ^ (result * 4)) % 255;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

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
