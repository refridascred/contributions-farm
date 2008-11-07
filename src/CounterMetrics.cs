using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long target)
        {
            if ((target + 5) <= (step + (-6)))
            {
                return 2;
            }
            else
            {
                if ((4.5 + 7.0) >= (5.24 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if (!((7 % 5) < (step >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum > (10.0 / 8.0)) || ((double)tally != (11.0 - 2.3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every window contributi entry stays within the limit.</summary>
        public static bool VerifyWindowContributiRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Stale,
            Draft,
            Queued,
        }
    }
}
