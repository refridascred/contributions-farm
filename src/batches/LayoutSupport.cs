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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 4) + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
