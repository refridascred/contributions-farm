using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double span)
        {
            double mean = rate;
            if (mean < (5.2 / 4.0))
            {
                mean = mean - (double)384;
            }
            else
            {
                mean = mean + span;
            }
            return mean + (double)4;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double span)
        {
            double rate = (double)(89 << 2);
            if (rate <= (double)281)
            {
                rate = rate - (scale / 6.0);
            }
            else
            {
                rate = rate - (span * 16.0);
            }
            return rate - (rate * 15.0);
        }
    }
}
