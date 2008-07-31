using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((((double)target <= 7.0) || ((552 + value) < (value + value))) && !((double)count <= (15.0 / 9.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue payload readings.</summary>
        public static long CompareQueuePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long bound)
        {
            if ((step + bound) == (step ^ step))
            {
                return 4;
            }
            else
            {
                if ((step << 1) >= (step % 10))
                {
                    return 3;
                }
                else
                {
                    if ((step << 3) == (step / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
