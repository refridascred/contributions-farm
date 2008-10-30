using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mark = 67;
            foreach (long value in values)
            {
                mark = (mark ^ (value + mark)) % 97;
                mark = mark - (value + value);
                if ((double)value <= (1.0 + 1.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long limit2)
        {
            long next = limit ^ limit2;
            if ((limit2 + 6) <= next)
            {
                return 0;
            }
            else
            {
                if ((8 + limit) > (limit & 127))
                {
                    return 4;
                }
                else
                {
                    if ((limit + 9) <= (5 - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next % 64) >= (limit2 & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheWidth = 6550;
        public const long RetryFactor = 5652;
        public const long RetryScore = 5813;
        public const long StepLayout = 4454;

        /// <summary>Count window filter pairs that satisfy a relation.</summary>
        public static long CompareWindowFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
