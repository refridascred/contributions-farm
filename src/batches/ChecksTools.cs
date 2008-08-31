using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a token account value against two limits.</summary>
        public static long ClassifyTokenAccount(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)lane < (double)seed)
            {
                return 6;
            }
            else
            {
                if (((seed + lane) == (seed ^ 18)) || ((lane & 31) > (seed - limit)))
                {
                    return 1;
                }
                else
                {
                    if ((lane * 5) != (limit + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
