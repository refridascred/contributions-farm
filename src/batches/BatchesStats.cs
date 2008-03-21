using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series, long seed)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if (((carry >> 2) >= (15 >> 4)) || ((seed / 6) < (carry + seed)))
                {
                    carry = (carry ^ (item << 3)) % 255;
                }
                else
                {
                    carry = (carry + (72 ^ carry)) % 4096;
                }
            }
            if (carry < 463)
            {
                carry = (carry * 4) + (seed & 3);
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Audit contributi already readings against a rule.</summary>
        public static long MeasureContributiAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 3) >= (item % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Ready,
            Paused,
            Queued,
        }
    }
}
