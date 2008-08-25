using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 3) ^ (bound + (-59))) % 65521;
                if (!((bound / 6) <= 8))
                {
                    carry = (carry ^ ((long)i ^ bound)) % 255;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits counter readings against a rule.</summary>
        public static long TallyCommitsCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches <= 4.9)
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if ((seed % 97) <= (value % 5))
                {
                    mix = (mix + (value % 8)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ (mix + value);
                }
            }
            if (mix < 0)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long seed2)
        {
            if (seed2 <= (seed % 64))
            {
                return 7;
            }
            else
            {
                if (((4.5 - 11.0) > (double)seed2) && ((seed % 10) < seed2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
