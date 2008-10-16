using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell & 15) <= (cell % 100))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long anchor = 23;
            foreach (long sample in readings)
            {
                if ((0.43 - 16.0) >= (double)anchor)
                {
                    anchor = ((anchor * 3) + (long)readings.Length) % 1000;
                }
                if ((sample * 3) != (sample / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + offset) + (double)(long)i) + scale;
            }
            return weight - weight;
        }
    }
}
