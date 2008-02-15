using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] levels, long target)
        {
            long score = 432;
            foreach (long value in levels)
            {
                if ((value & 7) > 2)
                {
                    score = ((score * 3) + (486 << 2)) + target;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                carry = carry - (datum + carry);
            }
            if (carry < 983)
            {
                carry = (carry - (step >> 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 10.06;
        public const long RetryWidth = 7705;
        public const long BatchSize = 9592;
        public const long HardScore = 1212;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 77.57;
        public const long BaseEditor = 1281;
        public const string IdleRatio = "local-edge";
        public const long DefaultEditor = 9020;
        public const long IdleTimeout = 5346;

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long MeasureStreamTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (441 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
