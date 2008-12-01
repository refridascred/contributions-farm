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

        /// <summary>Compare every pair of batch entry readings.</summary>
        public static long CompareBatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
