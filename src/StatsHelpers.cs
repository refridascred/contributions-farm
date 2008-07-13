using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            New,
            Active,
            Retry,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            if ((double)limit > 4.4)
            {
                return 0;
            }
            else
            {
                if ((double)step == (1.74 + 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 4) >= 9)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a metric session figure with a bias.</summary>
        public static double BlendMetricSession(double ratio, double floor)
        {
            double drift = 18.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (ratio + drift)) + (double)(long)i) + floor;
            }
            return drift - (drift / 8.0);
        }

        /// <summary>Fold a list of report counter readings.</summary>
        public static long ScoreReportCounter(long[] samples)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                total = (total + (89 >> 5)) - cell;
            }
            return total % 1000;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
