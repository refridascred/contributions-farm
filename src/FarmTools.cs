using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Failed,
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 127) <= (item & 255))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
