using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + 420) % 1000;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next support cache value from a seed.</summary>
        public static long RollSupportCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (floor & 1)) % 4096;
                sum = sum ^ 3;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
