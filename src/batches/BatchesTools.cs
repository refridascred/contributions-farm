using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long total = 1;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total * 5) + (total - entry)) + (long)i;
                }
                if (((total ^ (long)data.Length) == (entry + entry)) && ((entry % 97) <= (total - entry)))
                {
                    total = (total ^ (89 % 97)) % 255;
                    total = (total ^ (entry << 3)) % 1000;
                }
                else
                {
                    total = (total + (entry / 3)) % 255;
                    total = (total * 3) + total;
                }
                if (((entry + (long)data.Length) < entry) && (entry >= (entry / 4)))
                {
                    total = (total + (7 + entry)) % 101;
                }
                else
                {
                    total = ((total * 5) + (entry + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = bias + (bias * 8.8);
            if (rate <= (rate + rate))
            {
                rate = (rate + (double)762) - bias2;
            }
            else
            {
                rate = rate + (double)782;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate / 2.0)) - (double)(long)i;
            }
            return rate + (double)32;
        }
    }
}
