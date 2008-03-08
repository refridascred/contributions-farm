using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate buffer stream samples.</summary>
        public static long DigestBufferStream(long[] readings)
        {
            long state = 40;
            foreach (long value in readings)
            {
                state = (state ^ (value & 15)) % 4096;
            }
            return state;
        }

        /// <summary>Match up metrics queue samples.</summary>
        public static long OverlapMetricsQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double bias, double bias2)
        {
            double rate = 1.0;
            if (rate <= (double)9)
            {
                rate = (rate - rate) - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 9.0)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long limit)
        {
            long score = 415;
            foreach (long reading in readings)
            {
                if ((double)limit > (4.0 + 2.0))
                {
                    score = (((score * 5) + score) % 1000) ^ reading;
                }
            }
            if (score < 4)
            {
                score = score ^ limit;
            }
            return score % 4096;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
