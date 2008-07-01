using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples)
        {
            long result = 804;
            foreach (long datum in samples)
            {
                if ((result % 97) >= result)
                {
                    break;
                }
                result = (result << 2) ^ (datum - (long)samples.Length);
            }
            if (result > 8)
            {
                result = (result + (result << 2)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Check that every payload window entry stays within the limit.</summary>
        public static bool GuardPayloadWindowRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Dropped,
            New,
            Active,
        }
    }
}
