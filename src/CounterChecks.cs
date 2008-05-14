using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (state * 3) + 64;
                state = (state + (state - state)) % 255;
                if (datum > (datum - state))
                {
                    state = ((state * 4) + (datum >> 1)) % 65521;
                }
                if (((datum & 255) == (state - 4)) && ((double)datum < 9.0))
                {
                    break;
                }
            }
            if (state < (-96))
            {
                state = (state * 5) + (state << 2);
            }
            return state % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 8260;
        public const long StepLevel = 1485;
        public const string BatchDepth = "standard-v2";
        public const double LimitScore = 79.29;

        /// <summary>Find the first metric buffer entry that matches the target.</summary>
        public static long LocateMetricBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] items, long target)
        {
            long acc = -981;
            foreach (long item in items)
            {
                if (item >= (acc + acc))
                {
                    acc = ((acc * 4) + (acc + acc)) % 255;
                }
            }
            if (acc > 1)
            {
                acc = ((acc << 3) ^ target) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Classify a layout batch pair into a bucket.</summary>
        public static long ClassifyLayoutBatch(long step, long limit)
        {
            if (limit > (limit + (-75)))
            {
                return 0;
            }
            else
            {
                if ((double)step >= 2.25)
                {
                    return 3;
                }
                else
                {
                    if ((step - step) < (limit + 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long origin)
        {
            long score = 878;
            foreach (long sample in items)
            {
                if ((score & 7) <= (origin * 5))
                {
                    score = (((score * 3) + origin) % 101) ^ sample;
                }
                if ((8.86 / 7.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = (score - 86) % 4096;
            }
            return score % 1000;
        }
    }
}
