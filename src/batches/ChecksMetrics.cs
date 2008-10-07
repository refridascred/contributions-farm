using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of notes farm entries.</summary>
        public static long TallyNotesFarm(long[] series, long seed)
        {
            long state = 43;
            foreach (long cell in series)
            {
                state = ((state * 3) + cell) + seed;
            }
            return state;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long prev = offset + bound;
            if (!((98 >> 2) <= (offset + bound)))
            {
                return 6;
            }
            else
            {
                if (43 <= prev)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 4) < (0 + bound)) || (bound >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound == (5.33 - 6.79)) || ((-91) >= (prev + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double drift = (double)(657 * 4);
            if (drift < bias)
            {
                drift = (drift - (double)1) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)56) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Retry,
            Draft,
        }
    }
}
