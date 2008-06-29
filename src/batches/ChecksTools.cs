using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit format graph readings against a rule.</summary>
        public static long MeasureFormatGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches << 3) <= (6 / 8))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats graph value from a seed.</summary>
        public static long StepStatsGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)seed >= (9.64 / 2.0)))
                {
                    score = (score + (long)i) % 101;
                    score = ((score * 5) + (seed - seed)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long seed)
        {
            if (!((8 & 1) == (offset >> 4)))
            {
                return 7;
            }
            else
            {
                if (!(9.6 < (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((7 % 100) > (191 ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next token farm value.</summary>
        public static double BlendTokenFarm(double bias, double bias2)
        {
            double load = (bias - 15.0) - 6.72;
            if (load > (bias2 - load))
            {
                load = load + (load / 9.0);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + bias2) + (double)(long)i;
            }
            return load + (bias + bias);
        }
    }
}
