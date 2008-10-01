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

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "legacy-1";
        public const string LimitSchema = "primary";
        public const string WindowSchema = "latest";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
