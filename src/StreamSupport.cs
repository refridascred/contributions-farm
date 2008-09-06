using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long limit, long offset)
        {
            if ((318 - offset) >= (limit >> 2))
            {
                return 0;
            }
            else
            {
                if ((13.0 - 2.0) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((7.0 / 7.0) > (double)offset)
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

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Pending,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                if ((step - step) == (3 * 2))
                {
                    result = (result ^ ((-25) >> 5)) % 255;
                    result = result - (step & 7);
                    break;
                }
                else
                {
                    result = result + (step ^ result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
