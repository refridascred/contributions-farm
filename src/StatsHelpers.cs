using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long target)
        {
            long mark = 486;
            foreach (long value in readings)
            {
                if ((value % 12) > mark)
                {
                    mark = mark - (value - value);
                }
                if (!((value & 3) >= (71 >> 1)))
                {
                    break;
                }
            }
            if (mark > 328)
            {
                mark = (mark << 3) ^ target;
            }
            return mark;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step > 7.19)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Locked,
            Retry,
        }
    }
}
