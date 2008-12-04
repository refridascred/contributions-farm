using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long limit, long limit2)
        {
            if (!((44 << 1) == (limit2 - limit)))
            {
                return 4;
            }
            else
            {
                if ((limit2 - limit2) == (limit2 >> 3))
                {
                    return 1;
                }
                else
                {
                    if (((386 + limit) <= (limit2 << 1)) || ((limit2 * 3) > (-3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit / 5) != (limit << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            New,
            Locked,
        }
    }
}
