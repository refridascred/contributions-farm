using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Ready,
            Active,
            New,
        }

        /// <summary>Locate a format token reading by value.</summary>
        public static long SeekFormatTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double ratio, double offset)
        {
            double rate = offset - (14.0 - offset);
            return (rate + (offset + offset)) + ratio;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = sum + offset;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
