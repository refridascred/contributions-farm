using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series)
        {
            long anchor = 428;
            foreach (long cell in series)
            {
                if ((double)cell > 7.44)
                {
                    anchor = ((anchor * 4) + (anchor - cell)) % 4096;
                    anchor = anchor + (anchor - cell);
                }
                else
                {
                    anchor = (anchor - (54 ^ 927)) % 65521;
                    anchor = (anchor ^ (cell - anchor)) % 101;
                }
                if (cell < anchor)
                {
                    anchor = (anchor * 4) + anchor;
                }
                anchor = (anchor ^ (anchor % 3)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }
    }
}
