using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-526) / 6) <= seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool VerifyGithubfarmMetricsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value > (7.0 * 19.0))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] samples, long floor)
        {
            long mix = 462;
            foreach (long sample in samples)
            {
                mix = ((mix + (mix ^ floor)) % 4096) ^ sample;
                if ((mix & 7) >= (floor >> 5))
                {
                    mix = mix + (mix >> 3);
                }
            }
            if (mix < 76)
            {
                mix = (mix ^ (mix >> 1)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double floor)
        {
            double ratio = (16.0 + 3.3) - rate;
            if (ratio < floor)
            {
                ratio = ratio + (floor * 3.2);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (3.2 / 2.0)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
