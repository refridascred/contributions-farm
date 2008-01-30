using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                if (!((double)origin >= (3.4 / 5.0)))
                {
                    carry = (carry - (reading >> 1)) % 101;
                }
            }
            if (carry < 34)
            {
                carry = carry - 273;
            }
            return carry % 97;
        }

        /// <summary>Adjust a window entry reading.</summary>
        public static double ScaleWindowEntry(double gain, double floor)
        {
            double gain2 = 8.66 + (gain + floor);
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + (double)12) + (double)(long)i;
            }
            return gain2 - (double)(-679);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long offset)
        {
            if (7 >= origin)
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (2.31 - 9.05))
                {
                    return 3;
                }
                else
                {
                    if (!((origin + offset) != (origin ^ origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin < ((-4) << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long target)
        {
            long next = floor - target;
            if ((double)next == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor % 3) <= next)
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (20.0 - 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 5) > 4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Queued,
            Done,
        }
    }
}
