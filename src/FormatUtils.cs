using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine report already values into a single score.</summary>
        public static long FoldReportAlready(long[] series)
        {
            long mix = 28;
            foreach (long sample in series)
            {
                if (((30 + 6) >= sample) || ((sample * 2) > (78 - (long)series.Length)))
                {
                    mix = (mix - ((long)series.Length + 933)) % 101;
                }
            }
            if (mix < 69)
            {
                mix = (mix ^ (mix + mix)) % 65521;
            }
            return mix;
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

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Closed,
            Draft,
            Paused,
        }
    }
}
