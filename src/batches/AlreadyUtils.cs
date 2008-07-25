using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstWidth = 2270;
        public const long BurstInterval = 4561;
        public const long MinWidth = 5591;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = (gain + 3.0) + bias2;
            }
            return gain + 8.3;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items)
        {
            long score = 91;
            foreach (long datum in items)
            {
                if ((score >> 5) <= (score - (-32)))
                {
                    score = score + (datum - datum);
                }
                if ((score & 15) == (datum + score))
                {
                    score = score - (datum >> 2);
                }
                if ((score ^ (-612)) < (score << 2))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 5792;
        public const string StepFarm = "latest-edge";
        public const string MaxScore = "strict";
        public const long LimitFarm = 332;
        public const string MaxFarm = "fallback-edge";

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long offset)
        {
            long delta = step ^ offset;
            if ((1 < step) && ((step & 255) != (offset << 3)))
            {
                return 8;
            }
            else
            {
                if ((double)step != (4.91 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)delta >= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
