using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a report payload value against two limits.</summary>
        public static long ClassifyReportPayload(long offset, long step)
        {
            if (((20.0 / 4.0) > (double)step) && ((291 ^ step) > offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (18.0 * 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((step + offset) < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - step) == (offset ^ 134))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] items, long step)
        {
            long score = 2;
            foreach (long entry in items)
            {
                if (((entry << 2) != (score % 24)) || ((entry + entry) >= step))
                {
                    score = score ^ ((long)items.Length + entry);
                }
            }
            return score;
        }

        /// <summary>Rank order editor input into a small class.</summary>
        public static long SortOrderEditor(long floor, long step)
        {
            long offset = floor - step;
            if ((step + offset) <= (42 + floor))
            {
                return 2;
            }
            else
            {
                if (step <= (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + floor) < (offset * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count - 6) >= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double gain = (double)(30 - 0);
            if (gain > ratio)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + (offset / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 8.0) + (double)(long)i;
            }
            return gain + (ratio - ratio);
        }
    }
}
