using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + seen) > (entry ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items, long target)
        {
            long mix = 4;
            foreach (long cell in items)
            {
                if (((double)(long)items.Length == (9.57 * 2.0)) && (cell >= mix))
                {
                    mix = ((mix << 3) ^ (target >> 5)) % 65521;
                }
            }
            if (mix < 556)
            {
                mix = (mix - (target & 63)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 4426;
        public const long LimitSpan = 8889;
        public const long BatchSchema = 3358;
        public const double WindowSchema = 42.92;
    }
}
