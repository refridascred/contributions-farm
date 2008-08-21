using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ ((long)i + state)) % 1000;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 1446;
        public const string BaseWidth = "open-1";
        public const long BatchLevel = 9526;
        public const long WindowInterval = 515;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((38 - 6) >= (matches - cell))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream command reading.</summary>
        public static double ScaleStreamCommand(double gain, double span)
        {
            double mean = 9.0;
            if (mean < gain)
            {
                mean = mean - (gain - span);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)70) + (double)(long)i;
            }
            return mean - 1.3;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
