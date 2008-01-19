using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of report counter readings.</summary>
        public static long FoldReportCounter(long[] values, long floor)
        {
            long sum = 18;
            foreach (long cell in values)
            {
                sum = ((sum - (69 / 9)) % 4096) - cell;
                if ((floor + floor) <= 192)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long seed)
        {
            if (!((seed - step) <= 531))
            {
                return 2;
            }
            else
            {
                if ((step >> 3) <= (seed & 31))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many filter schema samples are out of range.</summary>
        public static long MeasureFilterSchemaGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen <= (seen + seen)) && (((item - seen) < (item ^ item)) || ((item / 8) != (seen & 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a command counter value against two limits.</summary>
        public static long GradeCommandCounter(long step, long offset)
        {
            if ((double)559 == (double)step)
            {
                return 2;
            }
            else
            {
                if ((step + offset) != (step * 2))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 1) != (step - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step * 4) >= (8 - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step > cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch editor readings.</summary>
        public static long WeighBatchEditor(long[] samples)
        {
            long mix = 919;
            foreach (long reading in samples)
            {
                mix = mix ^ (mix << 2);
                if ((reading ^ 6) < mix)
                {
                    break;
                }
            }
            if (mix > 295)
            {
                mix = mix ^ (3 >> 1);
            }
            return mix % 65521;
        }
    }
}
