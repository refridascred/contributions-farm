using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            New,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Count report editor pairs that satisfy a relation.</summary>
        public static long PairReportEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
