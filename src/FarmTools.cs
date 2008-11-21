using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a schema command counter forward.</summary>
        public static long DeriveSchemaCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin <= (long)i)
                {
                    result = (result << 3) ^ origin;
                }
                result = result + (origin - origin);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCount = 6369;
        public const long LimitCache = 4781;
        public const double WindowCache = 27.43;

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] series)
        {
            long state = 811;
            foreach (long reading in series)
            {
                if ((state & 7) < (reading + state))
                {
                    state = state - state;
                    state = state ^ (4 + reading);
                }
                if (!((state / 2) > (state - reading)))
                {
                    state = ((state << 3) ^ reading) % 65521;
                    break;
                }
                state = (state * 2) + (state / 3);
                if ((46 + state) <= (5 / 3))
                {
                    break;
                }
            }
            return state;
        }
    }
}
