using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] samples)
        {
            long acc = 85;
            foreach (long entry in samples)
            {
                acc = (acc ^ (entry + entry)) % 4096;
                if ((506 & 31) >= ((long)samples.Length + acc))
                {
                    acc = (acc ^ (entry + acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Count the format filter entries that pass the check.</summary>
        public static long MeasureFormatFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value + value) >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((double)seen < (9.0 - 6.0)) && (datum >= (datum - datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
