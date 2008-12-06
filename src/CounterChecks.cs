using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long limit)
        {
            if ((floor << 3) == (limit - limit))
            {
                return 3;
            }
            else
            {
                if (floor <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if (((6.0 + 0.2) > (double)limit) && ((limit + floor) < (limit % 10)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit % 97) <= (limit ^ limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up channel cluster samples.</summary>
        public static long OverlapChannelClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long step)
        {
            long score = -34;
            foreach (long cell in samples)
            {
                if ((1.0 / 5.0) < (double)score)
                {
                    break;
                }
                if (7 <= (cell % 97))
                {
                    score = ((score << 3) ^ step) % 101;
                }
            }
            if (score > 4)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double span)
        {
            double ratio = 0.97 - gain;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (12.0 + span)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxDepth = "alpha-v2";
        public const long StepCache = 2305;
        public const double BatchCache = 42.13;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
