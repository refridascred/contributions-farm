using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                if ((cell & 127) >= (9 >> 4))
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    anchor = anchor - (93 << 3);
                }
            }
            if (anchor < 698)
            {
                anchor = (anchor * 2) + (anchor % 5);
            }
            return anchor % 97;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i >= (origin - origin))
                {
                    acc = (acc + (acc + origin)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc * 2)) % 255;
                }
                acc = (acc << 2) ^ origin;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double bias, double floor)
        {
            double drift = bias;
            return drift + (floor + floor);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
