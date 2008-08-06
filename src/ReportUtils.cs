using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long limit)
        {
            long cur = target ^ limit;
            if (((limit + 435) <= 654) && ((limit / 7) <= ((-17) + cur)))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= (double)cur)
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

        /// <summary>Project the next tools contributi value.</summary>
        public static double ScaleToolsContributi(double scale, double offset)
        {
            double weight = (scale + 4.7) + (scale - offset);
            if (weight <= (weight - weight))
            {
                weight = weight - (double)45;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 4.77) + (double)(long)i;
            }
            return weight + 4.9;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5800;
        public const long SoftSpan = 6102;
        public const double DefaultLevel = 12.43;
        public const long LimitRatio = 9672;
    }
}
