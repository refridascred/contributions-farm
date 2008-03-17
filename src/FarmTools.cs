using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate graph route readings against a bound.</summary>
        public static bool CheckGraphRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score + score;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
