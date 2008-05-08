using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 218;
            foreach (long sample in readings)
            {
                if ((7.4 * 4.0) < (double)sum)
                {
                    sum = ((sum ^ (1 + (long)readings.Length)) % 1000) + sample;
                }
            }
            return sum;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Limit { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
