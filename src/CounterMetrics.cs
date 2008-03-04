using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            if ((seed + 0) > (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (4.0 + 8.3))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > 7.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit / 6) <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
