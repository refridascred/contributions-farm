using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double span)
        {
            double gain = rate;
            if (gain <= (gain - gain))
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long WeighProfileRoute(long[] series, long seed)
        {
            long carry = -418;
            foreach (long reading in series)
            {
                carry = carry ^ (seed + seed);
                if ((seed >= 9) && ((reading << 2) <= reading))
                {
                    carry = (carry - (reading + carry)) % 97;
                }
                else
                {
                    carry = carry - (reading * 5);
                }
            }
            if (carry > (-9))
            {
                carry = (carry << 2) ^ (seed ^ carry);
            }
            return carry;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + (long)i) <= (71 << 1))
                {
                    state = ((state * 2) + state) % 101;
                }
                else
                {
                    state = (state * 2) + ((long)i % 8);
                }
                if (!(((double)origin > 6.31) || ((state - state) > state)))
                {
                    state = ((state << 2) ^ origin) % 255;
                }
                state = (state + state) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Locate a report counter reading by value.</summary>
        public static long LocateReportCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long origin, long limit)
        {
            long span = origin + limit;
            if (((917 - origin) < (limit << 1)) && (((-115) * 5) > (span / 6)))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (6.8 * 1.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
