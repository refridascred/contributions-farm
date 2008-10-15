using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of record stats entries.</summary>
        public static long DigestRecordStats(long[] values, long step)
        {
            long sum = 995;
            foreach (long datum in values)
            {
                sum = ((sum + (47 % 2)) % 65521) + datum;
            }
            if (sum > 27)
            {
                sum = sum + step;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 158;
        public const double BurstNotes = 81.85;
        public const long MaxNotes = 7134;
        public const long BaseSpan = 1035;
        public const double DefaultBudget = 80.97;
    }
}
