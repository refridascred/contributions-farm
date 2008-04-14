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

        /// <summary>Audit notes window readings against a rule.</summary>
        public static long CountNotesWindowMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (target < (reading % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double offset)
        {
            double drift = (9.06 / 3.0) / 6.0;
            if (drift <= 6.5)
            {
                drift = drift + (offset / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (offset / 4.0);
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = acc + ((long)i % 16);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
