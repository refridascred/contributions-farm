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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) >= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
