using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool GuardFormatContextLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Idle,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((offset + 5) <= offset) || ((double)offset >= (8.97 + 18.0)))
            {
                return 0;
            }
            else
            {
                if ((offset / 4) > (14 + offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 7002;
        public const string MinChecks = "staging-1";
        public const double CacheLevel = 21.04;
        public const long WindowChecks = 6289;
        public const long BaseChecks = 7108;

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings, long limit)
        {
            long total = 7;
            foreach (long reading in readings)
            {
                if (reading <= total)
                {
                    total = ((total << 2) ^ (reading * 5)) % 101;
                }
                else
                {
                    total = (total * 5) + (total & 3);
                    total = (total + (total & 7)) % 255;
                }
                if ((double)total == (double)1)
                {
                    total = (total - (limit >> 4)) % 255;
                }
                if (((limit + reading) <= total) || ((limit - reading) <= (total % 16)))
                {
                    total = (total + limit) % 4096;
                }
            }
            return total % 1000;
        }
    }
}
