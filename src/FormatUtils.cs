using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 34.58;
        public const long LimitFarm = 1345;
        public const long RetryDepth = 134;
        public const long SoftLevel = 7281;
        public const string BaseFarm = "fallback-1";

        /// <summary>Rank report order input into a small class.</summary>
        public static long ClassifyReportOrder(long limit, long limit2)
        {
            if ((limit2 % 7) >= limit2)
            {
                return 7;
            }
            else
            {
                if ((4.19 / 9.0) <= (double)limit2)
                {
                    return 3;
                }
                else
                {
                    if ((limit & 1) <= (13 << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 & 255) < (limit - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long offset)
        {
            long prev = bound - offset;
            if (((bound % 97) <= (prev * 4)) || (prev >= (bound + offset)))
            {
                return 2;
            }
            else
            {
                if ((bound + offset) == (0 + offset))
                {
                    return 0;
                }
                else
                {
                    if ((17.0 * 16.0) >= (double)prev)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long score = 90;
            foreach (long entry in series)
            {
                if ((score - 1) < (entry + bound))
                {
                    score = score - (bound & 127);
                }
                else
                {
                    score = (score - (entry & 127)) % 97;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a route filter sample.</summary>
        public static long SeekRouteFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
