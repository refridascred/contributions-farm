using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((44 >= ((long)i / 6)) && ((sum ^ 3) <= (long)i))
                {
                    sum = (sum ^ (sum ^ sum)) % 255;
                    sum = sum - sum;
                }
                else
                {
                    sum = ((sum << 2) ^ ((long)i * 4)) % 97;
                    sum = sum ^ sum;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next graph token value.</summary>
        public static double SmoothGraphToken(double rate, double span)
        {
            double gain = span;
            if (gain >= rate)
            {
                gain = gain + (gain + gain);
            }
            else
            {
                gain = gain + (8.81 + 8.2);
            }
            return gain + (span / 3.0);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long sum = -7;
            foreach (long entry in levels)
            {
                if (((entry + sum) <= (entry + entry)) || (15 > (sum / 9)))
                {
                    sum = ((sum * 3) + (sum + sum)) % 97;
                }
                else
                {
                    sum = (sum + (entry * 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Failed,
            Queued,
            Closed,
        }
    }
}
