using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long limit2)
        {
            if ((double)20 != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (!(limit <= (limit + 899)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit2 == (8.1 + 3.22))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit2) <= (limit2 ^ limit))
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 689;
        public const string BatchDepth = "alpha";
        public const long MaxGithubfarm = 9685;
        public const long RetryGithubfarm = 5001;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            long step3 = step - step2;
            if (((step3 - step3) != (step3 - step)) || (((-48) + step2) >= (step << 3)))
            {
                return 7;
            }
            else
            {
                if (((800 + step3) != (step * 3)) || ((step * 2) <= (step3 + step2)))
                {
                    return 1;
                }
                else
                {
                    if ((step2 - step) > (-4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step2 + 33) <= (step2 / 4)) || ((step << 2) >= (7 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate format graph samples.</summary>
        public static long WeighFormatGraph(long[] readings, long bound)
        {
            long mix = 793;
            foreach (long item in readings)
            {
                if (((double)mix == (6.9 * 9.0)) || ((bound * 3) != (bound + (-94))))
                {
                    mix = ((mix << 3) ^ (item + mix)) % 1000;
                }
            }
            if (mix > 690)
            {
                mix = ((mix << 2) ^ ((-24) >> 1)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleLevel = 7904;
        public const long SoftRatio = 1945;
        public const long MaxOrder = 5047;
        public const string BurstSize = "standard-1";
    }
}
