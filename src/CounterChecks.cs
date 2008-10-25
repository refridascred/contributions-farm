using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Idle,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Check that every context format entry stays within the limit.</summary>
        public static bool GuardContextFormatBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 31;
            foreach (long item in values)
            {
                if (!((item - (long)values.Length) < (item % 5)))
                {
                    total = (total + (item + item)) % 1000;
                }
                total = (total + (item >> 2)) % 101;
            }
            if (total > 2)
            {
                total = (total + (3 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TotalBatchEntry(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if ((13.0 - 5.9) >= (double)limit)
                {
                    acc = (((acc * 2) + (long)samples.Length) % 1000) ^ cell;
                }
            }
            if (acc < 994)
            {
                acc = (acc << 3) ^ ((-7) - acc);
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + tally) >= (sample % 97))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
