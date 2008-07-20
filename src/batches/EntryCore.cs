using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double weight = offset;
            if (weight <= 2.3)
            {
                weight = weight - rate;
            }
            return weight + rate;
        }

        /// <summary>Match up stats batch samples.</summary>
        public static long OverlapStatsBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile stream series from a seed.</summary>
        public static long IterateProfileStream(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                long hits = ((long)i << 1) / 5;
                hits = (hits * 2) + (mark - 2);
                if (!((mark << 2) > (hits + limit)))
                {
                    mark = (mark + (mark - mark)) % 97;
                    mark = (mark + ((long)i / 7)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
