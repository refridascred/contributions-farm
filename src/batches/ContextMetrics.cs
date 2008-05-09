using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long bound)
        {
            long acc = -76;
            foreach (long datum in items)
            {
                acc = ((acc * 3) + (datum + 312)) - bound;
            }
            return acc % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstDepth = 6173;
        public const long BatchQueue = 6622;
        public const long IdleBudget = 531;
        public const long LimitDepth = 4678;

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long bound)
        {
            if ((11.0 - 4.9) <= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset << 1) != (660 + offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings)
        {
            long acc = -90;
            foreach (long cell in readings)
            {
                if ((double)cell <= 5.8)
                {
                    acc = (acc ^ cell) % 97;
                }
                acc = acc - 89;
                acc = (acc << 3) ^ (cell * 2);
            }
            return acc;
        }
    }
}
