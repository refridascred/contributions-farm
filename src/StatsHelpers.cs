using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double load = (double)538;
            if (load < (double)53)
            {
                load = load - bias;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias2) + (double)(long)i;
            }
            return load - (bias2 * 6.2);
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long BucketSchemaTools(long step, long floor)
        {
            if (((step + step) >= (floor ^ floor)) || (step >= (step % 100)))
            {
                return 7;
            }
            else
            {
                if (!((double)floor <= (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 90) < (step / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit notes filter readings against a rule.</summary>
        public static long CountNotesFilterHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((bound * 2) >= (39 ^ bound))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Project the next account contributi value.</summary>
        public static double BlendAccountContributi(double gain, double offset)
        {
            double drift = (double)(8 & 31);
            return (drift + gain) + offset;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double bias, double span)
        {
            double ratio = (double)(815 + 84);
            if (ratio <= bias)
            {
                ratio = (ratio + (double)72) + span;
            }
            return ratio + (ratio - 2.5);
        }
    }
}
