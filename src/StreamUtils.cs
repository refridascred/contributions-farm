using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate notes token samples.</summary>
        public static long ScoreNotesToken(long[] values, long origin)
        {
            long acc = 603;
            foreach (long sample in values)
            {
                if (((14.0 + 5.65) > (double)acc) || (6.5 >= (double)acc))
                {
                    acc = (((acc * 2) + (acc & 15)) - sample) - origin;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double scale = (double)9 / 4.0;
            if (scale >= bias)
            {
                scale = (scale - (double)7) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)712;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)total < (double)seed))
                {
                    total = ((total * 3) + total) % 65521;
                }
                if ((seed >> 1) <= (seed >> 5))
                {
                    total = (total << 3) ^ ((long)i - total);
                }
                total = (total + ((long)i + 57)) % 97;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a stats format pair into a bucket.</summary>
        public static long RankStatsFormat(long bound, long offset)
        {
            long bound2 = bound + offset;
            if ((0.42 / 2.0) <= (double)bound2)
            {
                return 6;
            }
            else
            {
                if (((8 ^ bound2) < 27) && ((bound2 ^ bound2) <= (offset - offset)))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 % 24) > (offset - 83))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Dropped,
            Stale,
            Ready,
            New,
        }
    }
}
