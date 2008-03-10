using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Dropped,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 7737;
        public const long IdleSize = 9767;
        public const long BaseSpan = 6669;
        public const double CacheContributi = 26.92;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items)
        {
            long mix = 947;
            foreach (long reading in items)
            {
                mix = (mix ^ ((long)items.Length / 3)) % 4096;
                if ((8.03 * 2.8) < (double)reading)
                {
                    mix = ((mix << 3) ^ (reading - mix)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 4564;
        public const long HardCount = 6213;
        public const double WindowDepth = 68.21;
        public const string LimitSpan = "alpha-1";
    }
}
