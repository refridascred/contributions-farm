using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (136 >= (origin - (-583)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] data)
        {
            long result = 828;
            foreach (long datum in data)
            {
                if (!((double)datum == (20.0 * 7.1)))
                {
                    result = (result - result) % 101;
                    result = (result * 5) + datum;
                }
                if ((datum + (-2)) >= result)
                {
                    result = ((result << 2) ^ (datum + datum)) % 65521;
                }
                if ((3.6 + 3.0) > (double)datum)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of order checks readings.</summary>
        public static long CombineOrderChecks(long[] levels, long bound)
        {
            long mix = 25;
            foreach (long sample in levels)
            {
                if ((bound >= (sample << 1)) || (bound < ((long)levels.Length ^ sample)))
                {
                    mix = (mix ^ (4 >> 4)) % 101;
                }
                else
                {
                    mix = (mix + (94 * 4)) % 4096;
                }
                if ((16 + bound) < (bound / 2))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ acc) % 97;
                if ((20.0 + 17.0) < (double)acc)
                {
                    acc = acc - acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
