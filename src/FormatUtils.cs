using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine farm record values into a single score.</summary>
        public static long CombineFarmRecord(long[] readings)
        {
            long total = 66;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ (reading * 4)) % 97;
                if (((total + 22) < (total ^ reading)) || ((total * 4) != (81 / 4)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double bias = floor;
            if (bias > scale)
            {
                bias = bias - scale;
            }
            else
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)49) - (double)(long)i;
            }
            return bias + (floor + scale);
        }

        /// <summary>Fold a list of channel report readings.</summary>
        public static long WeighChannelReport(long[] levels)
        {
            long result = 0;
            foreach (long sample in levels)
            {
                result = (result * 2) + 563;
                result = result - (sample + sample);
            }
            if (result < 853)
            {
                result = ((result << 2) ^ (result >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            if ((8.1 / 8.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)47 < (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long MeasureRecordChannelHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 7) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
