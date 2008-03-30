using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings)
        {
            long state = -874;
            foreach (long sample in readings)
            {
                state = ((state * 2) + (state - sample)) % 65521;
                state = (state ^ (state - state)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((limit - hits) >= (3 ^ hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long result = 25;
            foreach (long item in samples)
            {
                if (seed >= (708 - seed))
                {
                    result = (result + seed) % 101;
                    break;
                }
                else
                {
                    result = (result ^ item) % 255;
                }
                if ((double)result <= (5.1 / 9.0))
                {
                    result = result - (item + seed);
                }
            }
            return result;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data)
        {
            long acc = 4;
            foreach (long value in data)
            {
                acc = (acc * 3) + (acc + value);
                acc = (acc * 2) + (acc ^ 14);
                acc = acc ^ (value / 3);
                if ((value + value) < (value & 15))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
