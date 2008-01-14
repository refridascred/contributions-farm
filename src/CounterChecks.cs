using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowTimeout = 5013;
        public const long IdleRoute = 6453;
        public const long WindowRoute = 434;
        public const long BaseRoute = 5018;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i * 4) > (mark >> 3))
                {
                    mark = (mark * 3) + (mark << 1);
                    break;
                }
                else
                {
                    mark = ((mark * 5) + (mark / 7)) % 1000;
                    mark = ((mark << 2) ^ (mark / 7)) % 97;
                }
                if (((long)i >= origin) || ((double)origin != (7.0 + 5.0)))
                {
                    mark = (mark * 2) + (51 + mark);
                    mark = (mark - (origin + mark)) % 65521;
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark ^ (mark & 3)) % 97) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
