using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long origin)
        {
            long next = limit + origin;
            if (limit >= (0 / 3))
            {
                return 7;
            }
            else
            {
                if (((0.7 * 1.8) != (double)origin) && ((598 - next) != (origin << 1)))
                {
                    return 8;
                }
                else
                {
                    if (origin < (limit % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 2.24;
        public const long HardToken = 3117;
        public const double StepCount = 83.94;
        public const long MinToken = 350;
        public const string SoftSize = "open-v2";

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit batches account readings against a rule.</summary>
        public static long AuditBatchesAccountHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((double)origin == (0.4 - 16.0)) && (origin >= count)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
