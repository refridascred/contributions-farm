using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long limit, long floor)
        {
            if ((double)limit <= (1.7 - 0.4))
            {
                return 1;
            }
            else
            {
                if ((double)limit < (double)(-49))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor + limit) <= floor) || ((6.9 / 9.0) != (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step - result) >= (step - (long)i))
                {
                    result = (result + (step - step)) % 4096;
                    result = (result ^ (result ^ result)) % 4096;
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
