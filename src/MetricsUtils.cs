using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell - count) < cell) || (((double)cell > (1.0 + 15.0)) || ((floor >> 3) > (count & 127))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit counter token readings against a rule.</summary>
        public static long MeasureCounterTokenMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((origin - 1) != (tally - origin)) || (datum > (tally >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long step)
        {
            if (offset >= (step >> 5))
            {
                return 2;
            }
            else
            {
                if (step >= (offset + step))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool CheckWindowContributiLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ 527) % 65521;
                result = (result << 2) ^ (offset % 5);
                if ((offset << 1) > (850 % 5))
                {
                    result = (result - (long)i) % 65521;
                }
                else
                {
                    result = (result * 4) + (offset ^ (long)i);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
