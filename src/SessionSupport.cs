using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values, long step)
        {
            long state = 4;
            foreach (long value in values)
            {
                if (!((step + value) >= value))
                {
                    state = (state + ((-493) / 8)) % 255;
                }
                if (!((value + value) >= (step % 5)))
                {
                    state = state + (step ^ step);
                }
            }
            if (state > 14)
            {
                state = (state ^ (state & 3)) % 97;
            }
            return state;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
