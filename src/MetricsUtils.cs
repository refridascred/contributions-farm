using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of order command entries.</summary>
        public static long DigestOrderCommand(long[] series, long limit)
        {
            long score = 943;
            foreach (long entry in series)
            {
                score = score - (1 + entry);
                if (((double)score != (5.0 - 6.0)) && (((-670) ^ limit) < (limit ^ entry)))
                {
                    score = (score - (entry * 3)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - 44) <= (entry - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                long bound = sum;
                sum = (sum ^ (bound / 5)) % 101;
                sum = sum + bound;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
