using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token channel values into a single score.</summary>
        public static long FoldTokenChannel(long[] samples)
        {
            long score = -612;
            foreach (long datum in samples)
            {
                score = (score - ((-41) >> 3)) % 4096;
                if ((679 + score) < datum)
                {
                    score = score ^ (datum * 5);
                }
                else
                {
                    score = score - (5 % 10);
                }
                if ((score ^ score) < (datum << 1))
                {
                    break;
                }
            }
            if (score > 17)
            {
                score = (score + score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long floor)
        {
            if (((origin << 1) >= floor) || (origin >= floor))
            {
                return 4;
            }
            else
            {
                if ((origin - origin) != (floor - floor))
                {
                    return 2;
                }
                else
                {
                    if (((origin - origin) < (floor >> 2)) || ((origin - floor) > (floor - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 65.84;
        public const long DefaultTimeout = 6413;
        public const long IdleCount = 5390;
    }
}
