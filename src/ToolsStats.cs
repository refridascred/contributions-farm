using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long target)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                carry = (((carry - (carry & 255)) % 65521) + datum) + target;
                carry = (carry + ((-2) / 7)) % 255;
            }
            if (carry > 994)
            {
                carry = (carry ^ (carry - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double gain, double offset)
        {
            double load = gain;
            if (load > offset)
            {
                load = load + gain;
            }
            return load - (double)41;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long target, long limit)
        {
            long edge = target - limit;
            if (((double)target == (18.0 + 3.84)) || (6.0 >= (double)edge))
            {
                return 1;
            }
            else
            {
                if ((edge % 10) >= limit)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((16.0 / 5.0) >= (double)hits))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
