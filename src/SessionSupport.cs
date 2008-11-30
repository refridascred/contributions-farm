using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a graph command counter forward.</summary>
        public static long DeriveGraphCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if ((result << 2) < (step + result))
                {
                    result = (result << 3) ^ step;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
