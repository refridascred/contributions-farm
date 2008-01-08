using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = mix + mix;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowDepth = "strict-1";
        public const double WindowBudget = 85.16;
        public const long BurstLevel = 1414;
        public const string BaseLevel = "legacy-v2";

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length ^ seen) >= (item + 45))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
