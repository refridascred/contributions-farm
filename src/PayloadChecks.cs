using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double weight = (gain * 3.1) / 9.0;
            if (weight < gain)
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)1) + (double)(long)i;
            }
            return weight + (double)61;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels, long bound)
        {
            long score = -90;
            foreach (long datum in levels)
            {
                score = ((score * 4) + 6) + datum;
                if (52 <= (bound % 10))
                {
                    score = ((score * 3) + (bound + 706)) % 101;
                }
                else
                {
                    score = score + (score & 255);
                }
            }
            if (score < (-9))
            {
                score = score + (score % 97);
            }
            return score % 65521;
        }

        /// <summary>Rank entry metric input into a small class.</summary>
        public static long RankEntryMetric(long seed, long offset)
        {
            if ((seed >> 2) > offset)
            {
                return 6;
            }
            else
            {
                if ((seed & 1) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-90) << 3) < (seed << 3)) || ((seed << 1) < seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double weight = 8.4;
            if (weight < (double)(-387))
            {
                weight = weight + (bias - bias);
            }
            else
            {
                weight = weight + (weight - weight);
            }
            return weight - (weight + gain);
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
