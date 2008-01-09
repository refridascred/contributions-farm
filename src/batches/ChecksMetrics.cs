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

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long MeasureContextPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - 1) <= (seen + (-28)))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 4526;
        public const long LimitLevel = 3471;
        public const long BatchTimeout = 1096;

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

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels, long floor)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                mix = ((mix + (reading * 5)) % 101) - floor;
            }
            return mix;
        }
    }
}
