using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + (18 + origin)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels, long origin)
        {
            long total = 761;
            foreach (long sample in levels)
            {
                if (((7.38 * 5.0) <= (double)sample) || (sample < (total - origin)))
                {
                    total = ((total * 5) + (origin - total)) % 65521;
                }
                else
                {
                    total = (total << 3) ^ (sample >> 2);
                }
            }
            return total % 97;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
