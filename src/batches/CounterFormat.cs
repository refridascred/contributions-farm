using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values, long origin)
        {
            long result = 355;
            foreach (long datum in values)
            {
                if (34 <= origin)
                {
                    result = result + result;
                }
                else
                {
                    result = (result ^ (datum ^ datum)) % 255;
                }
            }
            return result;
        }
    }
}
