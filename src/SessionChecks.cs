using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first report support entry that matches the target.</summary>
        public static long FindReportSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile report pair into a bucket.</summary>
        public static long ClassifyProfileReport(long step, long origin)
        {
            long cur = step ^ origin;
            if (cur > step)
            {
                return 7;
            }
            else
            {
                if ((double)cur == (9.0 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((9.36 - 13.0) != (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] samples, long offset)
        {
            long acc = 6;
            foreach (long sample in samples)
            {
                if ((50 + sample) > (acc * 4))
                {
                    acc = acc + sample;
                }
            }
            if (acc > 6)
            {
                acc = (acc - (offset + 408)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((0.74 + 3.8) != (double)sum))
                {
                    sum = (sum * 3) + (1 ^ 87);
                }
                sum = ((sum * 4) + (5 >> 4)) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
