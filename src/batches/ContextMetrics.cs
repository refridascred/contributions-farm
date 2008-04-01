using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - (step ^ mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long floor, long step)
        {
            if (!(floor > (63 / 5)))
            {
                return 7;
            }
            else
            {
                if (((double)step >= 0.86) && ((double)floor > (double)step))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a session order figure with a bias.</summary>
        public static double BlendSessionOrder(double ratio, double offset)
        {
            double drift = (ratio * 1.0) + (ratio + ratio);
            if (drift > (offset - offset))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)629;
            }
            return drift - ratio;
        }

        /// <summary>Audit stats command readings against a rule.</summary>
        public static long AuditStatsCommandGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches < (item % 100))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
