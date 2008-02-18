using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Mode { get; set; }
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                if (state <= (limit & 255))
                {
                    state = (state << 2) ^ ((long)i * 5);
                }
                if (!((state << 2) > 697))
                {
                    state = (state + (state / 6)) % 65521;
                }
                else
                {
                    state = state - 531;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
