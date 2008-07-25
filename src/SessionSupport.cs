using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 40;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.0 * 6.49))
                {
                    score = score - (score >> 5);
                }
            }
            if (score < 204)
            {
                score = score - (score ^ (long)readings.Length);
            }
            return score;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long bound)
        {
            long diff = offset ^ bound;
            if ((44 + offset) < (diff + 3))
            {
                return 5;
            }
            else
            {
                if (offset <= bound)
                {
                    return 2;
                }
                else
                {
                    if (((double)bound >= (8.1 * 4.5)) && ((diff - 624) > (bound + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset << 3) < (offset + diff)))
                        {
                            return 8;
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
