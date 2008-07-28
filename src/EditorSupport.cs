using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseBudget = 7506;
        public const long WindowToken = 6291;
        public const string IdleToken = "strict-edge";

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long origin)
        {
            long carry = 631;
            foreach (long reading in data)
            {
                carry = (((carry + (carry - carry)) % 4096) ^ reading) - origin;
            }
            if (carry < 228)
            {
                carry = carry ^ (6 - carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 255;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)origin > (5.49 + 4.59))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
