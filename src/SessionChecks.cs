using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long step2)
        {
            if (step2 < step)
            {
                return 1;
            }
            else
            {
                if ((step2 * 4) < (step / 8))
                {
                    return 3;
                }
                else
                {
                    if ((step2 + step2) > (182 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((706 % 24) <= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - weight) + (double)(long)i) + ratio;
            }
            return weight - 6.0;
        }
    }
}
