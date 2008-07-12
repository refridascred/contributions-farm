using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long state = -68;
            foreach (long datum in readings)
            {
                if (((92 * 5) >= (datum & 31)) || ((double)bound < (6.0 / 8.0)))
                {
                    state = state ^ (695 & 31);
                }
            }
            return state;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double offset)
        {
            double scale = (offset - weight) / 5.0;
            if (scale >= (double)99)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)843;
            }
            return scale - (weight + scale);
        }

        /// <summary>Project the next schema stats value.</summary>
        public static double AdjustSchemaStats(double bias, double offset)
        {
            double rate = bias;
            return (rate + rate) + offset;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Active,
            New,
            Synced,
            Done,
        }
    }
}
