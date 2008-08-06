using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double gain2 = 19.0;
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 - gain2) + (double)(long)i) - gain;
            }
            return gain2 + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 13.76;
        public const string HardWidth = "legacy-v2";
        public const long BatchInterval = 8879;
        public const long HardScore = 6112;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Active,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long origin)
        {
            long result = 0;
            foreach (long cell in data)
            {
                result = (result << 2) ^ (cell - cell);
                result = ((result * 5) + (origin - result)) % 65521;
            }
            if (result < (-293))
            {
                result = (result + (origin * 4)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
