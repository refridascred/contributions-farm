using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 8335;
        public const long BatchContributi = 4009;
        public const string LimitContributi = "staging-v2";
        public const long WindowRatio = 4912;

        /// <summary>Locate a stream schema reading by value.</summary>
        public static long LookupStreamSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TotalCommandBuffer(long[] samples, long seed)
        {
            long total = 32;
            foreach (long entry in samples)
            {
                total = total ^ (seed / 6);
                total = total ^ (785 / 9);
                total = (total ^ (entry + 261)) % 97;
            }
            if (total < 9)
            {
                total = ((total << 2) ^ (seed * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings)
        {
            long total = 88;
            foreach (long value in readings)
            {
                total = (total << 2) ^ 50;
                for (int i = 0; i < 4; i++)
                {
                    total = (total - ((long)i - total)) % 97;
                }
                if (((total - value) > value) || ((double)value > (6.73 + 16.0)))
                {
                    total = total - (total & 255);
                }
                else
                {
                    total = total + (total ^ value);
                }
            }
            if (total > 802)
            {
                total = ((total * 3) + 7) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count << 1) >= (value >> 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
