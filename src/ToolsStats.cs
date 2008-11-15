using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long floor)
        {
            long slot = limit - floor;
            if ((259 + slot) >= (slot ^ slot))
            {
                return 4;
            }
            else
            {
                if (floor <= (limit * 4))
                {
                    return 1;
                }
                else
                {
                    if ((limit + floor) != (slot - slot))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((5.61 / 9.0) >= (double)tally))
                {
                    tally = ((tally + 3) + value) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Paused,
            Done,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset + 722) > (score - score))
                {
                    score = (score - (long)i) % 255;
                }
                score = (score << 2) ^ (score % 10);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset2 - limit) < (offset2 & 15))
            {
                return 7;
            }
            else
            {
                if (((offset2 >> 4) <= (offset + offset)) || ((offset2 - offset2) != (offset << 3)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 2) ^ (5 + (long)i)) % 65521;
                result = ((result * 3) + ((long)i + 839)) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
