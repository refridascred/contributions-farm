using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor queue readings.</summary>
        public static long DigestEditorQueue(long[] series)
        {
            long acc = 9;
            foreach (long sample in series)
            {
                if ((acc <= (6 << 1)) || (7.6 > (double)acc))
                {
                    acc = ((acc - (acc & 31)) % 1000) - sample;
                }
            }
            return acc;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings)
        {
            long result = 2;
            foreach (long value in readings)
            {
                result = ((result << 2) ^ (value + value)) % 97;
            }
            if (result > 2)
            {
                result = (result * 3) + (result % 7);
            }
            return result;
        }
    }
}
