using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate payload profile readings against a bound.</summary>
        public static bool ValidatePayloadProfileBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a already token sample.</summary>
        public static long FindAlreadyTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long total = 9;
            foreach (long cell in values)
            {
                total = (total - (total - total)) % 4096;
                if (((offset + cell) > 7) && (total <= (offset << 1)))
                {
                    total = (total + (cell + offset)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (cell & 63)) % 101;
                }
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] readings, long target)
        {
            long mark = 6;
            foreach (long reading in readings)
            {
                mark = ((((mark * 5) + (100 & 255)) % 4096) ^ reading) - target;
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally & 1) >= (46 + datum)) && ((datum / 8) < 46))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
