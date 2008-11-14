using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(6 >= (sum >> 4)))
                {
                    sum = (sum + (floor + floor)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double drift = bias / 6.0;
            if (drift >= (rate + bias))
            {
                drift = drift + (bias - drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (drift + drift);
        }

        /// <summary>Iterate the githubfarm profile series from a seed.</summary>
        public static long SeriesGithubfarmProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum - (step + (long)i2)) % 255;
                    sum = (sum * 5) + (step % 16);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (step < (tally + 0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
