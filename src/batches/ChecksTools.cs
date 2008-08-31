using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double ratio2 = (double)129 - (ratio - ratio);
            if (ratio2 > (double)73)
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + span) + (double)(long)i;
            }
            return ratio2 - (ratio2 / 5.0);
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a token account value against two limits.</summary>
        public static long ClassifyTokenAccount(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)lane < (double)seed)
            {
                return 6;
            }
            else
            {
                if (((seed + lane) == (seed ^ 18)) || ((lane & 31) > (seed - limit)))
                {
                    return 1;
                }
                else
                {
                    if ((lane * 5) != (limit + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
