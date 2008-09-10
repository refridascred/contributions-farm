using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchTimeout = 5503;
        public const long BurstWidth = 8234;
        public const double MinAlready = 67.07;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long floor)
        {
            if ((step >> 4) <= (floor + step))
            {
                return 2;
            }
            else
            {
                if (!((step + step) < floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < 7.36)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long acc = 61;
            foreach (long cell in series)
            {
                if (((cell + acc) == (acc % 64)) && ((17.0 * 10.0) <= (double)cell))
                {
                    acc = (acc - (acc / 7)) % 101;
                }
                else
                {
                    acc = (acc * 2) + acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate counter queue readings against a bound.</summary>
        public static bool CheckCounterQueueRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
