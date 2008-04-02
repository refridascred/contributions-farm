using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardSpan = "legacy-1";
        public const long StepCommand = 5795;
        public const long StepCount = 875;
        public const long SoftSize = 2192;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long limit)
        {
            long span = offset ^ limit;
            if (offset <= (offset - limit))
            {
                return 2;
            }
            else
            {
                if (((offset ^ limit) != (737 + span)) && (952 > (limit * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + limit) > (span % 64))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine contributi batches values into a single score.</summary>
        public static long FoldContributiBatches(long[] readings, long limit)
        {
            long anchor = 17;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)limit)
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (reading << 3)) % 255;
                }
                anchor = ((anchor * 5) + (limit / 9)) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
