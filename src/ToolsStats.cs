using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long floor2)
        {
            if ((floor / 3) == (floor / 4))
            {
                return 8;
            }
            else
            {
                if ((71 % 12) < (floor * 2))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (floor2 / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((-60) >= floor2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every token batch entry stays within the limit.</summary>
        public static bool CheckTokenBatchBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - sum;
                sum = sum - ((long)i >> 5);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] data)
        {
            long score = 32;
            foreach (long cell in data)
            {
                if ((cell / 6) != (score - score))
                {
                    score = (score - (score ^ score)) % 4096;
                    score = ((score * 5) + score) % 255;
                }
                score = (score * 2) + cell;
            }
            return score;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            New,
            Pending,
        }
    }
}
