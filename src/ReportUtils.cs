using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long mark = 664;
            foreach (long sample in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark << 3) ^ ((long)i ^ target)) % 97;
                }
                if ((sample - sample) != (mark & 255))
                {
                    mark = mark + (4 + sample);
                }
                else
                {
                    mark = mark - (sample + target);
                }
                if ((target >> 4) <= (sample - 8))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum >= count) || !(count >= (49 / 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double drift = (floor - floor) * 3.4;
            return (drift + (double)951) + gain;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((9.1 - 18.0) >= (double)seen) || ((reading ^ seen) < reading))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long bound)
        {
            long offset2 = offset - bound;
            if ((offset + bound) > (bound ^ bound))
            {
                return 2;
            }
            else
            {
                if ((offset2 ^ 321) < (offset2 >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((offset2 & 7) == (368 & 15)) || ((offset << 2) > offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((203 / 4) < (bound - bound)))
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
    }
}
