using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (scale + bias)) + (double)(long)i;
            }
            return bias + (bias - floor);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long origin)
        {
            long total = 87;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ (total - reading)) + origin;
                total = ((total * 2) + (reading - total)) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of layout stream entries.</summary>
        public static long WeighLayoutStream(long[] values)
        {
            long score = 569;
            foreach (long datum in values)
            {
                if ((score % 100) > ((long)values.Length - 968))
                {
                    score = (score ^ datum) % 97;
                }
                if ((datum << 2) < datum)
                {
                    score = (score + datum) % 4096;
                    score = score ^ (score * 5);
                }
                score = (score + (datum << 2)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
