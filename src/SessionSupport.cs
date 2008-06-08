using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Draft,
            Retry,
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long step, long bound)
        {
            if ((bound * 5) != (step << 3))
            {
                return 5;
            }
            else
            {
                if ((double)step > (2.76 / 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 4) >= (bound + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)7 > (7.7 / 8.0)) && ((step << 1) < (step + step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
