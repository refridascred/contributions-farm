using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the window report series from a seed.</summary>
        public static long StepWindowReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long floor)
        {
            long next = step + floor;
            if (floor <= next)
            {
                return 0;
            }
            else
            {
                if ((next * 3) != (step & 7))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((4 % 16) > (sample * 3)) && ((1.4 + 9.1) >= (double)origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseWidth = 13.95;
        public const double DefaultRatio = 9.8;
        public const long BurstCache = 5576;

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long seed)
        {
            long state = 46;
            foreach (long cell in values)
            {
                if ((double)state < (2.4 - 0.33))
                {
                    state = state + (seed & 15);
                }
                if ((seed ^ seed) > (state << 3))
                {
                    state = (state - (cell + (long)values.Length)) % 4096;
                }
            }
            if (state < (-68))
            {
                state = (state * 4) + (seed * 2);
            }
            return state;
        }
    }
}
