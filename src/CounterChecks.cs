using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((-5) < (sample & 1))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings)
        {
            long sum = -5;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum + (entry / 4)) % 4096) - (long)i;
                }
                if ((sum - entry) == (entry - sum))
                {
                    sum = (sum - entry) % 101;
                }
                if (((5.0 - 0.2) > (double)entry) || ((sum << 1) < (sum + entry)))
                {
                    break;
                }
            }
            if (sum < (-6))
            {
                sum = (sum ^ (sum - sum)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of payload editor readings.</summary>
        public static long OverlapPayloadEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if (!((floor - floor2) <= (floor - gap)))
            {
                return 3;
            }
            else
            {
                if ((3.84 / 8.0) >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches < (12.0 + 6.36))
                {
                    matches = ((matches + 2) ^ cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
