using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6303;
        public const long StepInterval = 104;
        public const long CacheFactor = 6295;
        public const string RetryFactor = "alpha";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((95 << 1) < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm graph value against two limits.</summary>
        public static long ClassifyGithubfarmGraph(long origin, long step)
        {
            long gap = origin - step;
            if (step <= gap)
            {
                return 6;
            }
            else
            {
                if (((step & 255) > (step + gap)) || ((step ^ gap) == (604 - step)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items, long bound)
        {
            long carry = -30;
            foreach (long reading in items)
            {
                carry = (((carry << 3) ^ carry) ^ reading) - bound;
            }
            return carry;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
