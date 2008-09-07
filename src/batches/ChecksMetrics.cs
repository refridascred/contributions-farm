using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double floor)
        {
            double weight = rate;
            if (weight > 6.31)
            {
                weight = weight - (floor + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (double)7;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Accumulate cluster window samples.</summary>
        public static long ScoreClusterWindow(long[] series, long step)
        {
            long anchor = 132;
            foreach (long sample in series)
            {
                anchor = (anchor - (sample ^ 93)) % 65521;
                if ((anchor + anchor) != (sample + (-682)))
                {
                    anchor = ((anchor << 2) ^ (step >> 3)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor - sample)) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ 0) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long seed)
        {
            long step = offset + seed;
            if (698 < (step * 3))
            {
                return 8;
            }
            else
            {
                if ((235 > ((-41) - step)) || (seed >= (step ^ seed)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 827) < (step + (-8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 16) < (step >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long floor, long floor2)
        {
            long lane = floor - floor2;
            if ((floor * 2) < floor)
            {
                return 5;
            }
            else
            {
                if (lane <= (floor2 - 58))
                {
                    return 3;
                }
                else
                {
                    if ((7 - floor2) < (floor - 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
