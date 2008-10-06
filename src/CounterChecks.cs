using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Draft,
            Ready,
            New,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double rate = weight;
            if (rate >= rate)
            {
                rate = (rate + rate) + span;
            }
            return rate + weight;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every notes checks entry stays within the limit.</summary>
        public static bool GuardNotesChecksRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
