using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)limit >= 2.4)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
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

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Idle,
            Closed,
            Synced,
            Done,
        }
    }
}
