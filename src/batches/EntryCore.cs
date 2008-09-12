using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((1 - matches) <= sample) || ((double)matches >= (2.6 / 5.0))) || (((matches << 2) == (sample - matches)) || (matches >= (matches % 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long bound)
        {
            if (bound > seed)
            {
                return 7;
            }
            else
            {
                if ((273 >> 1) <= seed)
                {
                    return 6;
                }
                else
                {
                    if ((bound + seed) < (seed >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound >= (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
