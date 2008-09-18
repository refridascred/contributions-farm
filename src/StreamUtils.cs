using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!!((13 - 701) < (matches ^ matches)))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account queue readings.</summary>
        public static long FoldAccountQueue(long[] samples, long step)
        {
            long mix = 1;
            foreach (long value in samples)
            {
                mix = ((mix * 3) + (value - 0)) + step;
            }
            if (mix > 16)
            {
                mix = (mix ^ 90) % 97;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "cached-1";
        public const long WindowStream = 501;
        public const long StepStream = 8555;
        public const long BaseStream = 6860;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Done,
            Retry,
        }
    }
}
