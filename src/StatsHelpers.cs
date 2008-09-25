using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a route report figure with a bias.</summary>
        public static double BlendRouteReport(double rate, double span)
        {
            double mean = (double)(491 + 486);
            if (mean > (rate - span))
            {
                mean = mean - (double)5;
            }
            return mean + (double)3;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
