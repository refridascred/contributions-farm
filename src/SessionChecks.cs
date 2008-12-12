using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long anchor = 549;
            foreach (long cell in samples)
            {
                if (!((double)cell < (0.75 - 5.1)))
                {
                    anchor = anchor + (6 & 7);
                }
                else
                {
                    anchor = anchor + (anchor - step);
                }
            }
            if (anchor < (-588))
            {
                anchor = (anchor + 8) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long step)
        {
            if ((double)origin != (3.0 * 0.2))
            {
                return 4;
            }
            else
            {
                if (step < (origin / 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= 7.0)
                    {
                        return 6;
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
