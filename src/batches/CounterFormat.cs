using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Done,
            Paused,
        }
    }
}
