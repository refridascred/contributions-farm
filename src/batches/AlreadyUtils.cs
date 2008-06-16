using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double weight = (double)(754 + (-896));
            if (weight < (double)418)
            {
                weight = ((weight - (double)(-205)) - gain) + floor;
            }
            return weight - (weight / 7.0);
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long diff = step + origin;
            if (((step + origin) < (diff << 2)) && ((double)origin > (20.0 + 15.0)))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (6.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff > (4.4 * 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin > (double)193) || (644 < step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((sum + offset) == (offset + sum)) && ((sum - sum) <= (sum >> 1)))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double span)
        {
            double ratio = (weight / 3.0) / 8.0;
            return (ratio - weight) + span;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = mark - (mark % 24);
                mark = (mark - (mark + mark)) % 255;
                mark = ((mark << 3) ^ (mark - offset)) % 1000;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
