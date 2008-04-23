using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long mix = 0;
            foreach (long value in series)
            {
                mix = mix + (value << 3);
                if (((1.6 - 2.0) > (double)(long)series.Length) || ((20.0 + 5.07) != (double)value))
                {
                    mix = ((mix * 4) + (value + value)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Combine stats graph values into a single score.</summary>
        public static long DigestStatsGraph(long[] samples, long step)
        {
            long score = -341;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (item >> 1)) % 4096;
                if ((step & 31) < (item - 321))
                {
                    score = (score - (346 ^ step)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long bound)
        {
            if (!((floor - floor) <= (floor - bound)))
            {
                return 0;
            }
            else
            {
                if (((double)bound > (double)floor) || ((11.0 / 9.0) > (5.5 - 4.44)))
                {
                    return 2;
                }
                else
                {
                    if (((-171) - bound) >= (bound + floor))
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

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Done,
            Stale,
            Closed,
            Retry,
        }
    }
}
