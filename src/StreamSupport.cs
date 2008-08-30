using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long result = 58;
            foreach (long value in data)
            {
                result = ((result + (long)data.Length) % 4096) + value;
            }
            if (result > 40)
            {
                result = (result << 3) ^ (result - result);
            }
            return result % 4096;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long bound)
        {
            if ((double)bound >= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor + bound) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((27 / 3) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound & 31) <= (bound / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a already format figure with a bias.</summary>
        public static double ScaleAlreadyFormat(double bias, double floor)
        {
            double bias2 = 6.0 - 4.2;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + floor;
            }
            return bias2 - bias;
        }
    }
}
