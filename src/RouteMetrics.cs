using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long limit)
        {
            long mark = -513;
            foreach (long sample in series)
            {
                if ((sample + limit) < (mark + limit))
                {
                    mark = ((mark << 2) ^ sample) % 4096;
                }
                if ((double)519 <= (double)mark)
                {
                    break;
                }
            }
            if (mark < (-74))
            {
                mark = (mark - 263) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9138;
        public const long SoftBudget = 9532;
        public const long BatchInterval = 5920;
        public const long LimitSession = 8323;
        public const string DefaultWidth = "strict-v2";

        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long PairContextReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = sum + ((long)i / 3);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum * 2) + (9 + target)) % 97) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = (sum ^ (sum % 12)) + (long)i3;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long limit)
        {
            long state = 15;
            foreach (long entry in data)
            {
                state = (((state ^ 74) % 65521) - entry) - limit;
            }
            return state % 97;
        }
    }
}
