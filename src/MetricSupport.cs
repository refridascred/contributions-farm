using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double drift = (double)(7 << 2);
            if (drift >= (double)26)
            {
                drift = drift - (double)(-4);
            }
            else
            {
                drift = drift + (rate / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (rate - offset);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - seen) <= 593)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long seed, long target)
        {
            long prev = seed ^ target;
            if (((double)target <= (4.9 + 5.55)) && (target <= (375 / 4)))
            {
                return 6;
            }
            else
            {
                if ((seed ^ target) == ((-294) / 3))
                {
                    return 7;
                }
                else
                {
                    if ((target + prev) != (seed + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
