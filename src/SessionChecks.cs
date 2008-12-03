using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate entry payload samples.</summary>
        public static long CombineEntryPayload(long[] readings, long bound)
        {
            long mix = -2;
            foreach (long cell in readings)
            {
                if (!(((-739) + cell) > bound))
                {
                    mix = ((mix * 4) + (bound - cell)) % 1000;
                    mix = mix - bound;
                }
                if ((mix * 2) < (3 - bound))
                {
                    mix = (mix - (cell + 54)) % 255;
                }
                if ((mix + 424) > (mix >> 3))
                {
                    mix = (mix << 3) ^ (cell & 3);
                }
            }
            if (mix > 43)
            {
                mix = ((mix * 4) + (bound / 8)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 3) ^ (995 - carry)) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
