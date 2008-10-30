using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftRatio = 6644;
        public const long BurstFormat = 9761;
        public const long CacheInterval = 5610;

        /// <summary>Rank batch graph input into a small class.</summary>
        public static long GradeBatchGraph(long floor, long bound)
        {
            long edge = floor ^ bound;
            if (floor > bound)
            {
                return 8;
            }
            else
            {
                if ((edge / 3) == (edge & 15))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (edge << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor % 8) >= (bound - floor)) && (edge <= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema cache readings.</summary>
        public static long CompareSchemaCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum - ((long)i + sum)) % 97;
                if ((step / 8) == (step ^ step))
                {
                    sum = (sum ^ (long)i) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
