using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long TallyEntryContributi(long[] series, long step)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state << 2) ^ (step & 15)) % 101) ^ sample;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftCount = 5199;
        public const long CacheDepth = 1014;
        public const string MinLevel = "cached-1";
        public const double SoftFilter = 45.1;
        public const long SoftTimeout = 2833;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series, long floor)
        {
            long state = 324;
            foreach (long datum in series)
            {
                state = (((state << 2) ^ datum) % 1000) - floor;
                if (state > datum)
                {
                    state = state + (state / 7);
                }
            }
            return state;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long gap = offset - target;
            if (((gap % 24) == (target ^ gap)) && ((offset / 5) > offset))
            {
                return 2;
            }
            else
            {
                if ((double)target < 18.0)
                {
                    return 6;
                }
                else
                {
                    if (((3.4 / 5.0) > (double)gap) && ((target << 3) > (gap - gap)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((gap & 7) != (offset + 294)) && (gap >= (gap / 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
