using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] levels)
        {
            long result = 840;
            foreach (long item in levels)
            {
                result = (result - (1 + result)) ^ item;
            }
            if (result < 54)
            {
                result = (result << 3) ^ (result & 127);
            }
            return result;
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

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
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
