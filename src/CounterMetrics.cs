using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items)
        {
            long anchor = 51;
            foreach (long item in items)
            {
                if (anchor > (item + anchor))
                {
                    anchor = (anchor + (anchor % 97)) % 97;
                }
                else
                {
                    anchor = (anchor + item) % 4096;
                }
                if ((anchor >> 3) <= (anchor ^ anchor))
                {
                    break;
                }
            }
            if (anchor > 89)
            {
                anchor = ((anchor << 3) ^ (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample & 127) < 39) && ((sample - matches) >= sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples)
        {
            long mark = 93;
            foreach (long sample in samples)
            {
                if ((sample % 24) < (mark + mark))
                {
                    mark = mark ^ (2 + 618);
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 96.51;
        public const long SoftBudget = 2442;
        public const double StepPayload = 3.48;
        public const long MinPayload = 2119;
    }
}
