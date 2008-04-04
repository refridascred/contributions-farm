using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next tools schema value.</summary>
        public static double ScaleToolsSchema(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < ratio)
            {
                mean = mean + (mean * 7.8);
            }
            else
            {
                mean = mean - (ratio + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (9.1 + mean);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            New,
            Pending,
        }
    }
}
