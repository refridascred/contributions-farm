using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items, long offset)
        {
            long acc = 7;
            foreach (long entry in items)
            {
                acc = ((acc + acc) + entry) + offset;
            }
            return acc % 1000;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
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
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = scale - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias / 6.0)) + (double)(long)i;
            }
            return scale + (double)48;
        }

        /// <summary>Project the next support record value.</summary>
        public static double SmoothSupportRecord(double ratio, double offset)
        {
            double drift = (double)(45 - 46);
            if (drift > (double)(-292))
            {
                drift = ((drift + (0.76 / 8.0)) + ratio) - offset;
            }
            return drift - drift;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public double Offset { get; set; }
        }
    }
}
