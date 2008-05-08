using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a batch route sample.</summary>
        public static long LocateBatchRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window queue series from a seed.</summary>
        public static long RollWindowQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!!(8 >= seed))
                {
                    carry = (carry * 2) + (seed - (long)i);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Count { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
