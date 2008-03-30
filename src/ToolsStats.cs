using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (origin > (reading % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 25;
            foreach (long cell in items)
            {
                if ((cell & 3) >= (sum / 4))
                {
                    sum = ((sum << 3) ^ (9 << 1)) % 1000;
                }
                else
                {
                    sum = (sum + (sum - cell)) % 101;
                }
                if (!((sum >> 4) >= (sum + cell)))
                {
                    sum = (sum + (cell ^ 43)) % 101;
                }
                else
                {
                    sum = (sum - (cell >> 2)) % 1000;
                }
            }
            if (sum < 15)
            {
                sum = (sum + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Count already route pairs that satisfy a relation.</summary>
        public static long MatchAlreadyRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics account counter forward.</summary>
        public static long StepMetricsAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((657 + carry) == (long)i))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (hits - 64))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
