using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a notes command value against two limits.</summary>
        public static long BucketNotesCommand(long target, long offset)
        {
            long cur = target + offset;
            if ((90 + cur) < ((-8) - target))
            {
                return 1;
            }
            else
            {
                if ((7.09 + 2.6) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((cur < (28 << 1)) || (cur < (target % 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stream metrics readings against a rule.</summary>
        public static long TallyStreamMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (7.5 > (double)tally)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long bound, long offset)
        {
            long step = bound - offset;
            if ((90 >> 5) == (bound - bound))
            {
                return 2;
            }
            else
            {
                if ((2.0 - 2.09) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= (9.54 + 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double gain = (double)(625 / 6);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - rate) + (double)(long)i) - span;
            }
            return gain + rate;
        }

        /// <summary>Scale a tools support figure with a bias.</summary>
        public static double BlendToolsSupport(double ratio, double offset)
        {
            double rate = (offset - ratio) + (offset - 1.5);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (1.93 + ratio);
        }
    }
}
