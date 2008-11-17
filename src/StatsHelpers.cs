using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long step2)
        {
            long offset = step + step2;
            if ((11.0 - 1.8) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if (step > offset)
                {
                    return 7;
                }
                else
                {
                    if (52 <= (step ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset - step2) < (offset >> 4)) && ((double)step <= 9.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "standard-v2";
        public const double RetryPayload = 11.55;
        public const string DefaultPayload = "fallback-1";
        public const double StepPayload = 16.3;
        public const long BatchSize = 9523;

        /// <summary>Audit support account readings against a rule.</summary>
        public static long MeasureSupportAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(((value + (-307)) > (8 << 1)) && (value <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 6782;
        public const string MaxCommits = "local-v2";
        public const long RetryDepth = 8401;
        public const string HardTimeout = "stable-edge";
        public const long BatchCommits = 4072;
    }
}
