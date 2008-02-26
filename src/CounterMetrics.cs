using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count support metric pairs that satisfy a relation.</summary>
        public static long PairSupportMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long origin, long limit)
        {
            if ((origin / 2) > (limit % 5))
            {
                return 0;
            }
            else
            {
                if ((origin / 3) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((limit % 12) <= (limit ^ 138)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi batch value from a seed.</summary>
        public static long RollContributiBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                long step = origin / 9;
                if ((5 - origin) > (step % 10))
                {
                    continue;
                }
                step = step + ((long)i / 2);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
