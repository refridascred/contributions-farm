using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            if (516 <= offset)
            {
                return 6;
            }
            else
            {
                if ((offset & 255) < (offset << 2))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 3) <= offset) || ((target + target) > (offset ^ offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((74 + target) >= (target & 31)) && ((target + 80) < target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a record cluster figure with a bias.</summary>
        public static double ScaleRecordCluster(double rate, double span)
        {
            double weight = (double)(5 - 460);
            return (weight + span) + rate;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long target)
        {
            long span = floor + target;
            if ((floor << 3) == (span + floor))
            {
                return 6;
            }
            else
            {
                if (!((span * 4) >= (target * 2)))
                {
                    return 0;
                }
                else
                {
                    if ((span * 3) > target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (5 > (floor - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
