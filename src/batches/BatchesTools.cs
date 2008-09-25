using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] samples, long step)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                if ((step + datum) == (step ^ datum))
                {
                    result = (result * 4) + result;
                }
            }
            if (result > 46)
            {
                result = ((result * 2) + (777 << 2)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ state) % 4096;
                state = state + (floor & 63);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
