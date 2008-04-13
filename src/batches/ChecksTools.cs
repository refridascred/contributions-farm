using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i == ((long)i ^ bound)))
                {
                    long edge = bound ^ 660;
                    total = total + edge;
                }
                total = (total << 3) ^ (6 & 31);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the payload metrics series from a seed.</summary>
        public static long RollPayloadMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + (sum + (long)i);
                if ((double)sum == (6.79 / 4.0))
                {
                    sum = sum - (offset + offset);
                    sum = ((sum << 3) ^ (offset ^ sum)) % 101;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if (((-702) + sum) > (sum - offset))
                {
                    sum = ((sum * 4) + 90) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
