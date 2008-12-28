using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if (2.81 < (double)(long)i)
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long floor, long bound)
        {
            if ((floor % 16) > 743)
            {
                return 0;
            }
            else
            {
                if ((576 << 1) == (floor << 1))
                {
                    return 8;
                }
                else
                {
                    if (bound < (bound / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((3.37 * 8.0) == (double)floor) && ((floor / 6) > (floor + bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 350;
        public const double MinFarm = 47.52;
        public const long BurstFarm = 1230;
        public const long WindowSize = 6553;
        public const string HardFarm = "legacy-1";
    }
}
