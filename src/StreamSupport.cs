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
        public const long WindowDepth = 48;
        public const string MaxNotes = "open-v2";
        public const long LimitCount = 2728;
        public const long StepNotes = 7184;
        public const double BurstFactor = 46.01;
    }
}
