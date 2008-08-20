using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long target)
        {
            long lane = step ^ target;
            if ((903 % 64) < (target - 32))
            {
                return 1;
            }
            else
            {
                if (((446 + 52) > lane) || (19.0 <= (double)step))
                {
                    return 5;
                }
                else
                {
                    if ((target / 4) > 82)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.8 + 3.7) != (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally > (661 % 5))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
