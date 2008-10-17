using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleTimeout = 1775;
        public const string DefaultTimeout = "standard";
        public const long BaseBatch = 5623;
        public const long LimitBatch = 2962;
        public const string MinDepth = "alpha";

        /// <summary>Define context limits and defaults.</summary>
        public const string HardCount = "alpha-1";
        public const long LimitLevel = 4638;
        public const long DefaultContext = 7301;
        public const long WindowContext = 6737;
        public const long LimitContext = 501;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + 4) >= reading)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long bound)
        {
            long total = -72;
            foreach (long reading in samples)
            {
                if (((total / 8) == ((-756) / 8)) && ((reading * 4) == (reading & 15)))
                {
                    total = ((total << 2) ^ (total & 15)) - bound;
                    total = (total * 2) + (total + total);
                }
                total = ((total * 5) + (total + total)) % 255;
                total = total + (total >> 5);
                if ((reading % 8) >= (total + total))
                {
                    break;
                }
            }
            if (total < (-12))
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long step)
        {
            if ((step - origin) >= 83)
            {
                return 3;
            }
            else
            {
                if ((step + origin) == (61 - step))
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
}
