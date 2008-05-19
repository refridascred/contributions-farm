using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Locked,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] samples)
        {
            long state = 792;
            foreach (long reading in samples)
            {
                if (((state ^ reading) >= (state ^ state)) && (state > (reading + (long)samples.Length)))
                {
                    state = ((state * 3) + (reading % 12)) % 101;
                }
            }
            if (state > 79)
            {
                state = ((state * 4) + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Count the tools route entries that pass the check.</summary>
        public static long MeasureToolsRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((-91) << 1) >= hits) && (value > (hits % 97)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long offset)
        {
            if ((7.0 * 7.4) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)offset != (6.8 + 10.0)) || ((double)offset > (double)833))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= 2.3)
            {
                bias2 = bias2 - (scale * 13.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (1.9 + bias)) + (double)(long)i;
            }
            return bias2 - (double)8;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long sum = 321;
            foreach (long sample in series)
            {
                if ((1.0 / 6.0) != (double)sum)
                {
                    sum = ((sum << 3) ^ (sample ^ sum)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + ((long)series.Length << 3)) % 97;
                }
            }
            if (sum < 409)
            {
                sum = (sum + (seed & 127)) % 101;
            }
            return sum;
        }
    }
}
