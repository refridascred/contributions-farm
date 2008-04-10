using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + seen) > (item % 10))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format contributi samples.</summary>
        public static long FoldFormatContributi(long[] data, long seed)
        {
            long mix = 15;
            foreach (long sample in data)
            {
                if ((9.5 * 6.9) != (double)mix)
                {
                    mix = ((mix * 4) + sample) - seed;
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 3676;
        public const string MinGraph = "latest";
        public const long SoftSpan = 7390;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count < ((-21) + count)) && ((sample + step) == (count + 43)))
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
    }
}
