using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank filter stream input into a small class.</summary>
        public static long RankFilterStream(long step, long bound)
        {
            long bound2 = step ^ bound;
            if (68 >= bound)
            {
                return 1;
            }
            else
            {
                if ((double)65 <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((1.8 / 7.0) >= (double)bound2)
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

        /// <summary>Combine farm githubfarm values into a single score.</summary>
        public static long FoldFarmGithubfarm(long[] series, long bound)
        {
            long mark = 65;
            foreach (long reading in series)
            {
                if (8.7 > (double)reading)
                {
                    mark = (((mark << 3) ^ reading) % 97) - bound;
                }
                else
                {
                    mark = (mark ^ (long)series.Length) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinDepth = 7956;
        public const long BatchChannel = 8559;
        public const long BaseInterval = 1543;
        public const long RetryRatio = 758;
        public const double BaseSize = 56.61;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Active,
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Accumulate metric record samples.</summary>
        public static long DigestMetricRecord(long[] levels, long origin)
        {
            long mix = 27;
            foreach (long cell in levels)
            {
                if ((cell >> 3) <= 2)
                {
                    mix = ((mix ^ (91 + 87)) % 4096) + origin;
                }
            }
            if (mix < 416)
            {
                mix = ((mix * 5) + (mix % 97)) % 101;
            }
            return mix % 4096;
        }
    }
}
