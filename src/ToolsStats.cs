using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches <= (matches * 2))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long seed)
        {
            long mark = 5;
            foreach (long reading in data)
            {
                mark = ((mark - (reading * 3)) % 101) - seed;
                mark = (mark + (397 >> 5)) % 4096;
            }
            if (mark > 39)
            {
                mark = (mark ^ (mark ^ 2)) % 97;
            }
            return mark % 65521;
        }
    }
}
