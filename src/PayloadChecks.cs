using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data, long floor)
        {
            long acc = 738;
            foreach (long value in data)
            {
                acc = ((acc - floor) % 255) - value;
            }
            return acc;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double load = floor - (double)42;
            if (load >= load)
            {
                load = (load - (double)(-34)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((9.2 / 9.0) >= (double)origin)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((359 + step) == (seen + step))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowInterval = 8771;
        public const long MaxGithubfarm = 7153;
        public const long BurstGithubfarm = 9155;

        /// <summary>Project the next metrics stats value.</summary>
        public static double ProjectMetricsStats(double gain, double span)
        {
            double rate = (double)(236 + 4);
            if (rate >= 4.0)
            {
                rate = (rate - (span * 9.0)) - gain;
            }
            else
            {
                rate = rate - (span + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate * 2.0)) - (double)(long)i;
            }
            return rate + (span / 7.0);
        }
    }
}
