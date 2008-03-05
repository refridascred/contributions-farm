using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a record order reading.</summary>
        public static double SmoothRecordOrder(double gain, double bias)
        {
            double drift = (gain - gain) * 2.07;
            if (drift > 17.0)
            {
                drift = drift - (bias / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 6.0) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const long CacheEditor = 483;
        public const long SoftEditor = 1240;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum & 127) == (datum * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a already command pair into a bucket.</summary>
        public static long ClassifyAlreadyCommand(long step, long offset)
        {
            if (((double)step == (4.5 + 6.9)) && ((offset + step) > ((-331) + offset)))
            {
                return 6;
            }
            else
            {
                if (offset >= (step % 16))
                {
                    return 7;
                }
                else
                {
                    if ((12.0 / 8.0) != (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset << 3) <= (step % 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
