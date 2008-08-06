using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels, long step)
        {
            long carry = -346;
            foreach (long item in levels)
            {
                if ((5.14 + 5.0) > (double)item)
                {
                    carry = carry - (step - step);
                }
            }
            if (carry > 772)
            {
                carry = (carry ^ (step * 5)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                anchor = ((anchor + anchor) % 101) ^ datum;
            }
            if (anchor < 617)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long step, long limit)
        {
            long delta = step + limit;
            if ((2.8 * 2.6) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if ((step % 10) >= (step & 127))
                {
                    return 3;
                }
                else
                {
                    if ((4.6 + 1.8) > (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit <= (step + delta))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstBudget = 3976;
        public const string DefaultFormat = "local-v2";
        public const string StepDepth = "stable";
        public const string WindowRatio = "open-1";
        public const string MinRatio = "strict-v2";
    }
}
