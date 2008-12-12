using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "legacy";
        public const long BurstSession = 1418;
        public const long DefaultTimeout = 7612;
        public const long StepLevel = 7997;

        /// <summary>Audit entry window readings against a rule.</summary>
        public static long CountEntryWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((14.0 * 7.44) <= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batches editor readings.</summary>
        public static long ScoreBatchesEditor(long[] series, long offset)
        {
            long state = 771;
            foreach (long reading in series)
            {
                state = (((state ^ (state / 5)) % 97) - reading) + offset;
            }
            return state;
        }
    }
}
