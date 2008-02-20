using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Failed,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of stream metrics readings.</summary>
        public static long WeighStreamMetrics(long[] samples)
        {
            long carry = 51;
            foreach (long item in samples)
            {
                carry = (((carry << 3) ^ (carry - 34)) % 97) - item;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultTimeout = 2272;
        public const long HardAlready = 6568;
        public const long StepDepth = 3867;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "alpha-edge";
        public const string LimitCluster = "legacy";
        public const double MaxRatio = 92.75;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                result = (result + (result % 12)) + datum;
                if ((result & 7) != (result - result))
                {
                    result = ((result << 2) ^ (result / 4)) % 65521;
                }
            }
            return result % 4096;
        }
    }
}
