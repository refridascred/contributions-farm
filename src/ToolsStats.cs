using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many counter format samples are out of range.</summary>
        public static long MeasureCounterFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ tally) < (tally % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long seed)
        {
            long delta = target + seed;
            if (target <= delta)
            {
                return 8;
            }
            else
            {
                if (target >= 467)
                {
                    return 0;
                }
                else
                {
                    if ((double)0 != (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(1 > target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally % 3) <= origin)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((seed ^ carry) <= seed) && (((long)i + (long)i) > (carry >> 5)))
                {
                    carry = (carry + (seed + seed)) % 1000;
                    carry = (carry + (carry / 4)) % 65521;
                }
                carry = carry + seed;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long sum = 49;
            foreach (long reading in values)
            {
                if ((reading >> 5) >= sum)
                {
                    sum = (sum ^ (7 + reading)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
