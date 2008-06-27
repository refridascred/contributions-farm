using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double mean = (double)(173 >> 2);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + floor) + (double)(long)i) - gain;
            }
            return mean + (double)56;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long offset)
        {
            if (((origin % 60) <= (offset - offset)) || ((double)origin >= (double)offset))
            {
                return 3;
            }
            else
            {
                if ((offset * 3) > (-806))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Adjust a support farm reading.</summary>
        public static double BlendSupportFarm(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (double)4) + (double)(long)i) + rate;
            }
            return ratio - ratio;
        }
    }
}
