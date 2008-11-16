using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long target, long step)
        {
            long diff = target - step;
            if (target >= ((-46) & 31))
            {
                return 1;
            }
            else
            {
                if ((2.0 + 3.74) >= (double)diff)
                {
                    return 5;
                }
                else
                {
                    if ((target & 127) <= (target % 24))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double drift = 3.2;
            return (drift - offset) + scale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 52.46;
        public const double BatchCount = 80.54;
        public const double SoftAlready = 49.15;
        public const string LimitAlready = "local";
        public const double IdleAlready = 27.68;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
