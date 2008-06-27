using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] series)
        {
            long mix = 443;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ mix) % 1000;
                if (11.0 > (double)datum)
                {
                    mix = mix - (datum / 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double load = scale;
            return load - (floor * 2.8);
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 22;
            foreach (long entry in values)
            {
                anchor = ((anchor << 3) ^ (478 ^ entry)) % 97;
                if ((anchor / 9) > (13 + entry))
                {
                    anchor = (anchor - (90 << 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
