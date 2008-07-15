using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a report window counter forward.</summary>
        public static long DeriveReportWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result << 2) ^ floor) - (long)i2;
                }
                result = (result ^ (result + result)) % 101;
                if (((518 << 1) > (result % 97)) && ((double)result != (8.0 * 1.25)))
                {
                    result = ((result << 2) ^ (floor & 31)) % 255;
                }
                else
                {
                    result = (result - (floor ^ (long)i)) % 4096;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 2) + (offset - offset);
                if ((1 - anchor) > anchor)
                {
                    anchor = (anchor ^ (long)i) % 97;
                }
                if (!(offset <= (anchor + (long)i)))
                {
                    anchor = (anchor * 3) + ((long)i + anchor);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two graph batches measurements.</summary>
        public static double ProjectGraphBatches(double rate, double offset)
        {
            double mean = rate;
            if (mean >= (4.5 / 6.0))
            {
                mean = mean - (mean - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (double)94;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
