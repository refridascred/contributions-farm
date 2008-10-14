using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] samples)
        {
            long result = -7;
            foreach (long datum in samples)
            {
                if (((result / 6) < 11) && ((result + 8) >= (result / 8)))
                {
                    result = (result + datum) % 1000;
                    continue;
                }
                result = (result - (513 ^ 26)) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count << 2) > 541) || ((double)count <= (5.21 + 4.0)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm token readings.</summary>
        public static long OverlapGithubfarmTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long limit, long target)
        {
            if ((limit << 3) == (target + limit))
            {
                return 4;
            }
            else
            {
                if ((target + target) < (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)limit <= (6.4 - 5.48)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long bound)
        {
            if ((double)bound <= 1.04)
            {
                return 8;
            }
            else
            {
                if (((14.0 * 5.0) != (double)seed) && (bound > (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) != (seed + 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
