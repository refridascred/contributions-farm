using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long bound)
        {
            long carry = 661;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry - (carry & 31)) + (long)i;
                }
                carry = ((carry * 2) + carry) % 255;
                if ((double)cell != (9.7 / 7.0))
                {
                    carry = (carry + (bound + carry)) % 101;
                }
                else
                {
                    carry = ((carry * 4) + (carry * 2)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Match up tools channel samples.</summary>
        public static long CompareToolsChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 4926;
        public const long BatchMetrics = 4519;
        public const string WindowWidth = "fallback";
        public const long HardMetrics = 9112;
        public const long LimitCount = 2549;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long floor, long origin)
        {
            if (((floor + origin) != (563 + 44)) || ((0.58 * 8.69) <= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((floor & 31) >= (origin + origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
