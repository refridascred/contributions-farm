using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up commits channel samples.</summary>
        public static long CompareCommitsChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support context values into a single score.</summary>
        public static long ScoreSupportContext(long[] readings, long offset)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                if (((offset + offset) >= offset) && ((5.5 / 2.0) > (double)offset))
                {
                    mark = mark - datum;
                }
                mark = mark ^ (offset % 8);
                if (((datum >> 5) < (offset + 143)) || (((long)readings.Length << 1) >= datum))
                {
                    mark = ((mark * 2) + offset) % 97;
                }
            }
            return mark;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 717;
        public const string SoftRoute = "staging";
        public const long CacheCount = 4120;
        public const string BaseBudget = "alpha";
        public const long DefaultRoute = 9368;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ (38 & 31)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
