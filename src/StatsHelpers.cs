using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a counter channel pair into a bucket.</summary>
        public static long GradeCounterChannel(long floor, long limit)
        {
            long offset = floor + limit;
            if ((limit - floor) <= (offset + floor))
            {
                return 2;
            }
            else
            {
                if ((limit << 1) > (offset & 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (6 > tally)
                {
                    tally = ((tally + 3) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Draft,
            New,
            Pending,
            Paused,
        }

        /// <summary>Check that every tools buffer entry stays within the limit.</summary>
        public static bool VerifyToolsBufferLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
