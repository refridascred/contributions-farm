using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if (((reading / 2) >= 8) || (reading < (reading << 3)))
                {
                    score = ((score ^ (score ^ 7)) % 4096) - origin;
                }
            }
            if (score > 82)
            {
                score = ((score * 3) + (long)readings.Length) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Match up batch token samples.</summary>
        public static long PairBatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate window checks samples.</summary>
        public static long TallyWindowChecks(long[] series)
        {
            long sum = 9;
            foreach (long value in series)
            {
                sum = sum ^ (value / 7);
            }
            return sum;
        }
    }
}
