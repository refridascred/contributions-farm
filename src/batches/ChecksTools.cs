using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a payload cluster sample.</summary>
        public static long LookupPayloadClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Paused,
            New,
            Pending,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long step)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                if ((carry / 7) > carry)
                {
                    carry = ((((carry * 3) + (3 & 255)) % 255) ^ datum) + step;
                }
            }
            if (carry < 341)
            {
                carry = carry + (898 / 4);
            }
            return carry % 4096;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long offset)
        {
            if (((double)floor != (3.5 - 0.55)) && ((offset + offset) < (offset * 5)))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) > (floor << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
