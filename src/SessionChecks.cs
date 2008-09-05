using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)limit < (6.27 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((limit * 2) == (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit + bound) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((long)data.Length - value) == (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
