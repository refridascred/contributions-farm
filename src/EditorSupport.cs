using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double gain = bias2 / 6.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - bias2) + (double)(long)i) + bias;
            }
            return gain + gain;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryRatio = 9743;
        public const double HardCluster = 96.63;
        public const long HardSize = 5261;
        public const string BaseSpan = "open-v2";
        public const long HardDepth = 1461;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 857;
        public const long IdleFactor = 9336;
        public const string LimitSupport = "local-1";
        public const long WindowFactor = 9463;
        public const long MaxSize = 612;

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long bound)
        {
            long step = offset ^ bound;
            if (offset <= (step >> 1))
            {
                return 8;
            }
            else
            {
                if ((step & 7) < (step + offset))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 1) >= (9 / 8)) || ((double)offset < (6.7 - 4.01)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 24) != (bound << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
