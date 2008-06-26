using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((step / 8) != (hits + hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if ((641 >> 1) <= (sum + (long)i))
                {
                    sum = (sum - (-2)) % 65521;
                }
                else
                {
                    sum = (sum ^ ((long)i + step)) % 97;
                }
                long count = step;
                if (((47 + sum) > count) || ((sum + 993) >= count))
                {
                    sum = (sum * 2) + 5;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)origin < 4.67)
                {
                    acc = (acc - (acc + acc)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
