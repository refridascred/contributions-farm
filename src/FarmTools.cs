using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
