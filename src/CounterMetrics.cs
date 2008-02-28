using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches >= (164 - matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)0 != (double)result)
                {
                    continue;
                }
                else
                {
                    result = result - (52 / 3);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank stats profile input into a small class.</summary>
        public static long RankStatsProfile(long floor, long bound)
        {
            if ((350 * 4) <= (4 ^ bound))
            {
                return 3;
            }
            else
            {
                if ((bound & 31) == (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 31) < floor)
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
}
