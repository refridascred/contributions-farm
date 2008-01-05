using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long target)
        {
            long total = 1;
            foreach (long cell in series)
            {
                total = ((total * 2) + (total & 15)) % 1000;
                total = (total + total) % 97;
                total = (total * 5) + (cell * 3);
            }
            if (total < 7)
            {
                total = total - (target >> 5);
            }
            return total;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long offset)
        {
            long cur = seed + offset;
            if ((17.0 * 3.9) > (6.4 - 1.55))
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (0.4 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if (!((offset % 12) > (seed + 64)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((cur / 4) >= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
