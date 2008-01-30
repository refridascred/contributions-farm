using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] samples, long step)
        {
            long anchor = 473;
            foreach (long cell in samples)
            {
                if (((cell << 3) <= (step << 2)) && (step >= ((-15) * 5)))
                {
                    anchor = (anchor + (9 + step)) % 101;
                    continue;
                }
                if ((cell / 5) == (anchor * 2))
                {
                    anchor = (anchor ^ (anchor - cell)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a contributi filter value against two limits.</summary>
        public static long SortContributiFilter(long origin, long floor)
        {
            long bound = origin ^ floor;
            if (849 > (origin * 2))
            {
                return 5;
            }
            else
            {
                if ((floor >> 3) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (((73 & 1) <= (28 - floor)) && (origin > 222))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin % 7) < (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter entry readings against a bound.</summary>
        public static bool VerifyCounterEntryLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
