using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data, long origin)
        {
            long anchor = 61;
            foreach (long value in data)
            {
                long step = 972;
                if (!((754 << 2) != (value ^ anchor)))
                {
                    anchor = (anchor + (step << 3)) % 1000;
                }
                if ((9 + value) <= anchor)
                {
                    anchor = (anchor ^ (long)data.Length) % 101;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 3) ^ ((long)data.Length + origin)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples)
        {
            long acc = 22;
            foreach (long sample in samples)
            {
                if ((double)sample <= 8.77)
                {
                    acc = acc - (31 + (-611));
                }
                else
                {
                    acc = (acc * 5) + (sample - acc);
                }
            }
            if (acc < 88)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 7039;
        public const long MaxDepth = 1486;
        public const double CacheSpan = 98.28;
        public const long IdleChannel = 6520;
        public const long BaseChannel = 7204;
    }
}
