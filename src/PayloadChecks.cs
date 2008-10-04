using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total + (903 & 31)) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Retry,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values)
        {
            long score = -400;
            foreach (long value in values)
            {
                if (!!((34 + score) > (47 ^ score)))
                {
                    score = ((score << 3) ^ (value << 2)) % 97;
                }
                if ((double)score < (13.0 * 2.0))
                {
                    score = (score + value) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((0.66 * 5.39) > (double)count) && (sample > (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
