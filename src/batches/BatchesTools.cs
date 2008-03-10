using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((sample < (count & 31)) || ((7 << 2) == (count % 8))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a window metric value against two limits.</summary>
        public static long RankWindowMetric(long origin, long origin2)
        {
            if (origin2 > origin)
            {
                return 2;
            }
            else
            {
                if ((origin & 15) != (origin2 & 31))
                {
                    return 6;
                }
                else
                {
                    if ((origin > 33) && (origin >= (0 + origin2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 12) >= (origin & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm schema entries that pass the check.</summary>
        public static long CountFarmSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((11 * 2) > (datum - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
