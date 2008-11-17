using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double scale, double floor)
        {
            double drift = floor;
            if (drift >= (drift - 3.0))
            {
                drift = drift - (14.0 * 0.2);
            }
            else
            {
                drift = drift - (scale / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (scale - floor)) + (double)(long)i;
            }
            return drift - (8.8 - scale);
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (limit % 60);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Pending,
            Done,
        }

        /// <summary>Iterate the commits counter series from a seed.</summary>
        public static long StepCommitsCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (origin % 97)) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long carry = 5;
            foreach (long sample in readings)
            {
                if (((double)carry >= (6.1 + 4.8)) && ((17.0 / 4.0) == (double)sample))
                {
                    carry = (carry - (sample + sample)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (sample + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
