using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a channel session pair into a bucket.</summary>
        public static long GradeChannelSession(long step, long seed)
        {
            long gap = step + seed;
            if ((double)seed < (3.0 + 12.0))
            {
                return 7;
            }
            else
            {
                if ((seed + step) <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((68 + step) <= (gap % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every commits filter entry stays within the limit.</summary>
        public static bool VerifyCommitsFilterBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two layout context measurements.</summary>
        public static double BlendLayoutContext(double weight, double span)
        {
            double bias = 8.3 / 8.0;
            if (bias >= (weight + bias))
            {
                bias = bias - (weight / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long floor)
        {
            long step = origin ^ floor;
            if ((origin > (step - origin)) && ((origin - origin) == (step * 5)))
            {
                return 0;
            }
            else
            {
                if (((origin + origin) >= floor) && ((origin - origin) > step))
                {
                    return 4;
                }
                else
                {
                    if ((step - 30) < (0 + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 60) <= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (origin < 21)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long seed)
        {
            if (((1.58 + 3.0) == (double)limit) || ((3.1 + 3.94) != (double)seed))
            {
                return 4;
            }
            else
            {
                if ((81 / 7) < seed)
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
