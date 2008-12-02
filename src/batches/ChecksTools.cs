using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long bound, long seed)
        {
            if (((seed + bound) > (bound * 5)) && ((double)bound == (5.52 * 4.3)))
            {
                return 2;
            }
            else
            {
                if (2.14 <= (18.0 * 12.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (716 <= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long step)
        {
            long offset = target ^ step;
            if ((20.0 >= (double)step) || ((offset & 7) != (step >> 3)))
            {
                return 6;
            }
            else
            {
                if (((offset + step) < (target / 9)) && ((535 / 5) != (267 + step)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
