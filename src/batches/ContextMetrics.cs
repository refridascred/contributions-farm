using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                long lane = (score ^ step) * 5;
                if ((lane >= (lane * 3)) || ((9.16 * 16.0) < (4.0 * 7.7)))
                {
                    score = (score << 2) ^ (lane ^ lane);
                    score = score - (long)i;
                }
                else
                {
                    score = ((score * 3) + ((long)i % 3)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length - (long)samples.Length) != (bound << 2))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7625;
        public const long RetryDepth = 4089;
        public const double BatchSchema = 85.17;
        public const long BaseSchema = 5873;
        public const long HardSchema = 9147;

        /// <summary>Combine filter stream values into a single score.</summary>
        public static long CombineFilterStream(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if (datum > 596)
                {
                    total = ((total * 2) + 848) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long mix = 675;
            foreach (long cell in values)
            {
                mix = (mix + (mix >> 1)) ^ cell;
            }
            return mix % 65521;
        }
    }
}
