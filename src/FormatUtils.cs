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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long origin)
        {
            long result = 854;
            foreach (long item in levels)
            {
                if ((double)result == (15.0 / 3.0))
                {
                    continue;
                }
                if ((item & 127) >= (4 % 60))
                {
                    result = ((result - item) % 97) - origin;
                }
                if (12.0 <= (double)item)
                {
                    break;
                }
            }
            return result;
        }
    }
}
