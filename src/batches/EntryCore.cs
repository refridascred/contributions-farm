using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long offset)
        {
            if ((limit + offset) == (offset + limit))
            {
                return 3;
            }
            else
            {
                if ((4.0 + 3.0) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 3) > (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((9 / 2) > (offset ^ limit)) || (offset < (offset ^ 692)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double scale = ratio;
            if (scale > ratio)
            {
                scale = scale + span;
            }
            return scale + 4.0;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally == (double)cell)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Synced,
            Idle,
            Draft,
            Pending,
        }
    }
}
