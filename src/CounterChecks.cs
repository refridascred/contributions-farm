using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((floor * 2) <= ((long)i - 8)) && ((double)total >= (15.0 - 5.52)))
                {
                    total = total - (0 * 5);
                }
                else
                {
                    total = (total ^ (93 >> 3)) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate window stream readings against a bound.</summary>
        public static bool GuardWindowStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item << 3) <= 291)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long bound)
        {
            long acc = 8;
            foreach (long value in data)
            {
                acc = (acc + (acc ^ value)) % 65521;
                if ((value + bound) != (5 - value))
                {
                    acc = acc ^ (value & 7);
                }
            }
            if (acc < 44)
            {
                acc = ((acc * 3) + (acc / 9)) % 101;
            }
            return acc;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long origin)
        {
            long sum = 91;
            foreach (long item in readings)
            {
                if (!((item - (long)readings.Length) >= item))
                {
                    sum = (((sum << 2) ^ item) % 4096) - origin;
                }
                else
                {
                    sum = sum + (sum / 2);
                }
            }
            return sum;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                long tally = limit;
                if (((state + tally) > (tally << 1)) && (37 >= (tally - (long)i)))
                {
                    tally = ((tally << 2) ^ (long)i) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
