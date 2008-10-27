using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen >= (bound ^ seen)) && ((item ^ 2) <= (seen + item)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                if ((1.2 * 1.42) <= (double)(long)i)
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 771;
        public const long IdleBatches = 3282;
        public const long CacheFactor = 1197;
        public const long CacheBudget = 4089;
        public const long BatchBatches = 9277;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long floor)
        {
            if (((872 ^ floor) < (step % 60)) && ((318 % 7) <= (floor >> 5)))
            {
                return 5;
            }
            else
            {
                if (floor > (step - 6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
