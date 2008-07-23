using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Retry,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double weight = (double)(496 + (-989));
            if (weight <= 5.43)
            {
                weight = (weight + bias2) - bias;
            }
            return weight + bias2;
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long ScoreStreamCounter(long[] data, long bound)
        {
            long state = 885;
            foreach (long value in data)
            {
                if ((30 + value) >= (bound + 34))
                {
                    state = (state * 2) + (state & 63);
                }
                else
                {
                    state = (state ^ value) % 101;
                }
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 29.61;
        public const double RetrySize = 46.97;
        public const long BatchRecord = 2475;
        public const long DefaultRecord = 7827;
        public const double StepSpan = 60.46;

        /// <summary>Measure how many batches metric samples are out of range.</summary>
        public static long TallyBatchesMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((hits + hits) < (hits + 330)))
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long offset)
        {
            long diff = origin ^ offset;
            if ((offset - origin) == (origin - 72))
            {
                return 4;
            }
            else
            {
                if ((origin * 2) > (diff & 7))
                {
                    return 1;
                }
                else
                {
                    if (!(((-410) + diff) < (offset >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
