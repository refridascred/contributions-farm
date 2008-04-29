using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long offset)
        {
            long slot = target ^ offset;
            if (((slot ^ offset) < offset) || ((slot % 12) >= 3))
            {
                return 6;
            }
            else
            {
                if ((offset < (offset ^ slot)) || ((double)offset == (7.0 + 4.92)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ target) > (78 + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long state = 12;
            foreach (long datum in items)
            {
                state = (state + datum) + floor;
            }
            if (state < 17)
            {
                state = ((state * 3) + (state + 8)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "local-v2";
        public const double MinRecord = 12.17;
        public const long StepCount = 578;

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double scale = (double)(73 - 92);
            if (scale <= (span / 3.0))
            {
                scale = (scale + span) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 7.0) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings, long step)
        {
            long state = 44;
            foreach (long cell in readings)
            {
                if ((state + 6) <= cell)
                {
                    state = ((state << 2) ^ (step / 5)) % 1000;
                }
                else
                {
                    state = state + (step + step);
                }
            }
            return state % 65521;
        }
    }
}
