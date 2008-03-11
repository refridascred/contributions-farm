using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long target)
        {
            if (((double)target < (15.0 - 8.0)) && (target > (limit * 2)))
            {
                return 0;
            }
            else
            {
                if (!((target + limit) >= (limit / 4)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Validate commits layout readings against a bound.</summary>
        public static bool VerifyCommitsLayoutLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of channel layout readings.</summary>
        public static long TotalChannelLayout(long[] levels, long origin)
        {
            long anchor = 579;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 2) ^ (origin % 12)) - entry;
                if (anchor < (anchor - anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 1)) % 1000;
                }
            }
            if (anchor > 42)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
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

        /// <summary>Audit route metrics readings against a rule.</summary>
        public static long TallyRouteMetricsGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((sample + count) > (seed & 127)) && ((count + (-668)) > (count + sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
