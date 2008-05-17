using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long step2)
        {
            long next = step + step2;
            if ((double)next >= (2.7 * 7.4))
            {
                return 1;
            }
            else
            {
                if (step2 >= (next - step2))
                {
                    return 7;
                }
                else
                {
                    if ((next << 2) <= (step / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit session metrics readings against a rule.</summary>
        public static long TallySessionMetricsGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) < (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream account figure with a bias.</summary>
        public static double ProjectStreamAccount(double weight, double offset)
        {
            double load = (double)(306 + 55);
            return (load - offset) + weight;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(7 <= item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix - ((long)i - mix)) % 1000;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix << 3) ^ (mix + mix)) % 255) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Stale,
            Retry,
            Failed,
        }
    }
}
