using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((double)entry == (double)(long)data.Length) || ((385 & 7) <= (entry << 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a session notes counter forward.</summary>
        public static long SeriesSessionNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ 667) % 65521;
                long lane = (long)i;
                if (!(offset < total))
                {
                    total = ((total << 3) ^ (lane * 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = gain - (gain * 16.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 9.97) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
