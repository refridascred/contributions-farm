using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (7.02 - 1.1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 4631;
        public const long RetryTools = 5043;
        public const long StepTools = 3178;
        public const long LimitTools = 5565;
        public const long SoftTimeout = 3834;

        /// <summary>Classify a route editor pair into a bucket.</summary>
        public static long ClassifyRouteEditor(long seed, long step)
        {
            if ((step * 3) > step)
            {
                return 3;
            }
            else
            {
                if (923 >= (step ^ step))
                {
                    return 2;
                }
                else
                {
                    if (step >= (90 + seed))
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

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
