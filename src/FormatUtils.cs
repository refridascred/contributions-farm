using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length > (limit >> 1)) && (((seen % 5) <= (limit % 97)) || ((seen + limit) >= seen)))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Rank cluster editor input into a small class.</summary>
        public static long SortClusterEditor(long target, long step)
        {
            if ((double)target <= (double)step)
            {
                return 7;
            }
            else
            {
                if (step > target)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next support already value from a seed.</summary>
        public static long DeriveSupportAlready(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total + step;
                total = ((total * 4) + 0) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = (score + origin) % 65521;
                score = score + (score + 9);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
