using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings)
        {
            long state = 16;
            foreach (long item in readings)
            {
                state = state + (item << 2);
                if (item > (state >> 2))
                {
                    state = (state << 3) ^ (item - 71);
                }
                if ((0.25 + 12.0) != (double)item)
                {
                    break;
                }
            }
            if (state < (-8))
            {
                state = ((state * 2) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading & 15) <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits >> 5) != (floor % 64)) && ((floor >> 2) > hits))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank stream checks input into a small class.</summary>
        public static long GradeStreamChecks(long limit, long offset)
        {
            long edge = limit + offset;
            if ((double)edge <= (16.0 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((limit > (633 - offset)) && ((double)edge != (7.0 - 9.4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (0.94 * 0.25))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
