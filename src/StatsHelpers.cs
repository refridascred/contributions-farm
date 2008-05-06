using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series, long offset)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (!((datum ^ acc) > (15 >> 4)))
                {
                    acc = ((acc << 3) ^ (acc >> 4)) % 101;
                    continue;
                }
                if (((long)series.Length - 68) == (0 & 15))
                {
                    acc = ((acc * 5) + (offset + acc)) % 101;
                }
            }
            if (acc > 797)
            {
                acc = ((acc * 3) + (offset << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Check that every schema metrics entry stays within the limit.</summary>
        public static bool ValidateSchemaMetricsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a commits cache sample.</summary>
        public static long LookupCommitsCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already tools readings against a bound.</summary>
        public static bool VerifyAlreadyToolsRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
