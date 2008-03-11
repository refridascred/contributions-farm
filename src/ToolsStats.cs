using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batches githubfarm samples are out of range.</summary>
        public static long MeasureBatchesGithubfarmOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9 + entry) > ((-692) + bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long state = 6;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ ((-74) >> 2)) % 97;
                if (476 <= ((-6) - reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double weight = 3.03;
            if (weight < rate)
            {
                weight = weight + (bias - bias);
            }
            else
            {
                weight = weight + 2.96;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long gap = offset + offset2;
            if (89 >= gap)
            {
                return 4;
            }
            else
            {
                if ((offset > (offset2 * 3)) || (offset2 > (gap % 64)))
                {
                    return 1;
                }
                else
                {
                    if (gap < (162 << 1))
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
}
