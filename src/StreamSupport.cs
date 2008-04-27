using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings, long bound)
        {
            long result = 57;
            foreach (long datum in readings)
            {
                result = result + (result >> 3);
                if ((result ^ result) == (result >> 2))
                {
                    result = (result * 5) + (bound + datum);
                }
            }
            return result;
        }

        /// <summary>Find the first contributi payload entry that matches the target.</summary>
        public static long LocateContributiPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long floor, long step)
        {
            long slot = floor + step;
            if ((floor + floor) < step)
            {
                return 8;
            }
            else
            {
                if ((floor * 3) >= (6 - (-1)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (5 + step)) && (4 > (slot - 88)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
