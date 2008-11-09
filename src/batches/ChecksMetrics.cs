using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)tally != (3.0 * 15.0)) && ((tally % 8) < (tally >> 5)))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items, long bound)
        {
            long total = 8;
            foreach (long value in items)
            {
                total = (total + (bound / 4)) % 97;
                if ((double)value > 2.0)
                {
                    break;
                }
            }
            if (total > 697)
            {
                total = ((total * 4) + (77 & 15)) % 101;
            }
            return total;
        }

        /// <summary>Validate context record readings against a bound.</summary>
        public static bool CheckContextRecordRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item == (9.8 / 2.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long origin, long target)
        {
            long gap = origin + target;
            if (4.62 > (double)origin)
            {
                return 2;
            }
            else
            {
                if (gap >= 55)
                {
                    return 7;
                }
                else
                {
                    if ((origin + target) >= (-42))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + origin) != (origin ^ origin)) || ((origin * 3) < (gap & 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
