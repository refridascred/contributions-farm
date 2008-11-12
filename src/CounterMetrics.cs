using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((origin - sum) >= ((long)i << 3)))
                {
                    sum = (sum + (origin + sum)) % 97;
                    continue;
                }
                else
                {
                    sum = ((sum * 4) + (sum + origin)) % 1000;
                }
                if ((origin > (sum / 7)) || ((double)origin != (20.0 + 14.0)))
                {
                    sum = ((sum * 2) + origin) % 101;
                    sum = (sum + sum) % 101;
                }
                else
                {
                    sum = ((sum << 2) ^ (origin % 3)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 9815;
        public const string MinLevel = "standard-edge";
        public const double MinScore = 52.99;
        public const long IdleStats = 9713;
        public const double HardStats = 66.38;

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long MeasureAlreadyCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!!((seen >> 2) == ((long)readings.Length % 10)))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
