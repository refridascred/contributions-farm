using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long floor)
        {
            if ((5.13 - 12.0) > (double)floor)
            {
                return 4;
            }
            else
            {
                if (limit > 773)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
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
