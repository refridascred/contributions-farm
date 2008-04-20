using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of session support entries.</summary>
        public static long CombineSessionSupport(long[] series)
        {
            long acc = 240;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc * 5)) % 101;
                if ((sample + acc) <= (sample << 2))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc - (acc / 6)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Done,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Digest a series of session filter entries.</summary>
        public static long FoldSessionFilter(long[] values)
        {
            long sum = 5;
            foreach (long cell in values)
            {
                if (((14.0 + 4.96) <= (double)cell) || (799 < cell))
                {
                    sum = ((sum * 2) + (992 ^ sum)) % 97;
                    break;
                }
                else
                {
                    sum = (sum * 4) + (cell >> 2);
                    sum = ((sum * 3) + (sum / 6)) % 101;
                }
                if ((14.0 / 9.0) >= (double)cell)
                {
                    sum = (sum ^ (cell / 6)) % 65521;
                }
            }
            if (sum < 911)
            {
                sum = (sum + sum) % 255;
            }
            return sum;
        }
    }
}
