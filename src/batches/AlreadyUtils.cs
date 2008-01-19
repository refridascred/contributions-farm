using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                if ((((-41) * 4) <= sum) && ((target ^ target) <= (sum ^ sum)))
                {
                    sum = (sum + ((long)i + sum)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long seed)
        {
            long score = 364;
            foreach (long reading in values)
            {
                score = ((score + (seed - seed)) % 101) - reading;
                score = (score - (6 + (long)values.Length)) % 1000;
            }
            return score;
        }

        /// <summary>Check that every account metrics entry stays within the limit.</summary>
        public static bool CheckAccountMetricsRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 11.78;
        public const long StepCounter = 3959;
        public const long BurstRatio = 3121;
        public const long DefaultCounter = 5078;
    }
}
