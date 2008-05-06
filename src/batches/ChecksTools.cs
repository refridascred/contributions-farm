using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double gain2 = bias;
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + 8.72;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data)
        {
            long score = 9;
            foreach (long reading in data)
            {
                if (((score ^ reading) == (37 - 4)) && ((double)score >= (5.3 - 8.5)))
                {
                    score = (score << 2) ^ (score - score);
                }
                if ((reading + score) < reading)
                {
                    score = (score - (reading / 4)) % 101;
                }
            }
            if (score > 94)
            {
                score = (score + score) % 65521;
            }
            return score;
        }
    }
}
