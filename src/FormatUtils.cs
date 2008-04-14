using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count < 495)
                {
                    count = ((count + 2) - reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Audit notes window readings against a rule.</summary>
        public static long CountNotesWindowMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (target < (reading % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long seed2)
        {
            if ((6.19 * 7.0) <= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((7 << 3) < (seed2 + seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed / 3) == (seed << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = carry - (floor + floor);
                carry = ((carry << 3) ^ (144 ^ floor)) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
