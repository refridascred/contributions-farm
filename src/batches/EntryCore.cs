using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit cluster entry readings against a rule.</summary>
        public static long MeasureClusterEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((12.0 / 9.0) >= (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 75.85;
        public const long DefaultNotes = 7077;
        public const long StepDepth = 9475;
        public const long BaseScore = 2775;
        public const long StepNotes = 6097;

        /// <summary>Rank farm support input into a small class.</summary>
        public static long SortFarmSupport(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if ((double)floor <= (3.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (((floor2 * 5) >= (gap / 8)) || ((floor & 3) >= (floor2 % 2)))
                {
                    return 8;
                }
                else
                {
                    if ((32 + gap) > (floor2 / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ gap) <= (floor2 % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = (((score * 5) + (22 / 9)) % 4096) - cell;
            }
            return score;
        }

        /// <summary>Classify a queue metric pair into a bucket.</summary>
        public static long GradeQueueMetric(long limit, long seed)
        {
            if (seed >= limit)
            {
                return 0;
            }
            else
            {
                if ((limit - limit) < (seed & 63))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) != (seed / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
