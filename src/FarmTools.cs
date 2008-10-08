using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate schema batch samples.</summary>
        public static long FoldSchemaBatch(long[] data, long bound)
        {
            long total = 3;
            foreach (long value in data)
            {
                if ((value >= (bound / 2)) || ((total - total) < value))
                {
                    total = (total + (total - (long)data.Length)) % 4096;
                    total = (total ^ (value + value)) % 97;
                }
                if ((746 + bound) != (value << 2))
                {
                    total = (total ^ (98 - bound)) % 65521;
                    continue;
                }
                else
                {
                    total = (total << 3) ^ 69;
                }
                if ((3.0 * 8.0) == (double)value)
                {
                    total = (total - (bound / 6)) % 101;
                }
            }
            if (total < 839)
            {
                total = (total + (bound * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ (origin & 1)) % 101) - (long)i2;
                }
                score = (score + (score + score)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a editor checks counter forward.</summary>
        public static long RollEditorChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
