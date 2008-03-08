using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Ready,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Check that every account profile entry stays within the limit.</summary>
        public static bool ValidateAccountProfileRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next tools report value from a seed.</summary>
        public static long IterateToolsReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum << 2) ^ (long)i2;
                }
                if ((99 + (long)i) <= sum)
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                else
                {
                    sum = (sum ^ (254 / 7)) % 4096;
                    sum = (sum << 2) ^ (278 << 1);
                }
                if ((double)sum == (8.0 * 4.0))
                {
                    sum = ((sum * 2) + (step + (long)i)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((959 + (long)items.Length) > (370 / 2))
                {
                    tally = ((tally + 3) + value) - target;
                }
            }
            return tally;
        }
    }
}
