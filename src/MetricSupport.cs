using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
