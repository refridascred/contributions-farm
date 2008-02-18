using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long floor)
        {
            long next = target ^ floor;
            if ((double)floor <= 9.96)
            {
                return 7;
            }
            else
            {
                if ((target >> 3) > (next * 5))
                {
                    return 0;
                }
                else
                {
                    if (floor > next)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((next < floor) && ((next & 127) <= (target ^ 66)))
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

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            New,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Locked,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double bias = (double)(455 + 87);
            if (bias <= (offset - ratio))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double rate = (double)(-578) / 3.0;
            if (rate <= rate)
            {
                rate = ((rate + (double)960) - ratio) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + 9.5;
        }
    }
}
