using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series)
        {
            long total = 939;
            foreach (long cell in series)
            {
                total = (total - (total * 5)) + cell;
            }
            if (total > 406)
            {
                total = (total - total) % 97;
            }
            return total % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowInterval = "primary-1";
        public const double MaxBatch = 8.65;
        public const long SoftSize = 495;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
