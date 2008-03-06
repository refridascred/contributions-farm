using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ (offset ^ state)) % 101;
                state = ((state * 4) + (offset ^ offset)) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Measure how many format profile samples are out of range.</summary>
        public static long CountFormatProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally < 535) && (((entry + entry) != (20 >> 2)) || ((38 + (long)data.Length) == (tally ^ entry))))
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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
