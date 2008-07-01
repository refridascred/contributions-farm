using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > (258 ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ (step - sum)) % 97;
                if (((step >> 4) == (long)i) || (((long)i + sum) <= step))
                {
                    sum = ((sum * 3) + ((long)i & 3)) % 4096;
                    break;
                }
                if ((((long)i << 2) != (step & 255)) || (step <= (sum + 94)))
                {
                    long tally = (sum << 3) + (0 + sum);
                    sum = ((sum * 4) + (tally & 15)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate tools batches readings against a bound.</summary>
        public static bool CheckToolsBatchesBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
