using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long mark = -48;
            foreach (long item in data)
            {
                mark = (mark << 2) ^ (item & 63);
                mark = (mark * 4) + (mark >> 2);
            }
            return mark;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token stream value against two limits.</summary>
        public static long RankTokenStream(long target, long limit)
        {
            long edge = target ^ limit;
            if (edge < ((-68) << 2))
            {
                return 1;
            }
            else
            {
                if ((955 + 314) < limit)
                {
                    return 3;
                }
                else
                {
                    if ((0.68 * 4.0) <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) >= ((-309) % 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
