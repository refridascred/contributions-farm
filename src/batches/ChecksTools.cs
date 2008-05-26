using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a route schema counter forward.</summary>
        public static long DeriveRouteSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 2) ^ (limit + limit)) % 97;
                if (((limit - limit) > limit) || ((long)i <= (limit - carry)))
                {
                    carry = carry ^ (carry << 1);
                    carry = ((carry << 3) ^ (limit << 2)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (target >= (target - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long floor)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((floor + floor) <= (state + reading))
                {
                    state = (state ^ 743) % 101;
                }
                else
                {
                    state = (state << 3) ^ (868 - state);
                }
            }
            if (state > 0)
            {
                state = (state + ((long)values.Length * 3)) % 4096;
            }
            return state;
        }
    }
}
