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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
