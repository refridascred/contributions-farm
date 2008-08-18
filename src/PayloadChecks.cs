using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ (407 / 2);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                if (!((946 & 7) != (mix * 3)))
                {
                    mix = mix - (mix & 1);
                }
                else
                {
                    mix = ((mix << 3) ^ (target ^ cell)) % 101;
                }
            }
            if (mix > (-8))
            {
                mix = mix + (mix << 1);
            }
            return mix % 4096;
        }
    }
}
