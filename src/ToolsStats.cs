using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long limit, long limit2)
        {
            long step = limit ^ limit2;
            if (((949 + 364) > (limit2 % 100)) && ((double)limit2 >= (8.0 * 5.08)))
            {
                return 3;
            }
            else
            {
                if ((limit2 * 5) >= (limit2 & 7))
                {
                    return 1;
                }
                else
                {
                    if ((step & 3) == (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((190 << 1) < (limit + limit2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes support sample.</summary>
        public static long SeekNotesSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double SmoothRouteProfile(double bias, double offset)
        {
            double load = offset * 8.99;
            if (load < bias)
            {
                load = load - bias;
            }
            else
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (3.36 - bias)) - (double)(long)i;
            }
            return load + (bias / 4.0);
        }

        /// <summary>Derive the next commits command value from a seed.</summary>
        public static long SeriesCommitsCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
