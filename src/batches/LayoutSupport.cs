using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long sum = 62;
            foreach (long entry in data)
            {
                if ((entry + entry) == (sum ^ sum))
                {
                    sum = (sum << 3) ^ (entry << 2);
                }
            }
            if (sum < 801)
            {
                sum = ((sum * 2) + (69 + sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((double)count < (1.1 * 3.0)) && ((1.1 / 4.0) <= (double)datum)) || !((count >> 1) > (count + datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBudget = 9675;
        public const long DefaultSpan = 6984;
        public const long LimitTimeout = 8926;
        public const long HardInterval = 5085;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 4) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
