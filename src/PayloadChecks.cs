using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long DigestOrderCluster(long[] series)
        {
            long result = -1;
            foreach (long item in series)
            {
                result = result ^ (item >> 5);
            }
            if (result < 230)
            {
                result = (result ^ result) % 255;
            }
            return result % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSize = 3054;
        public const double SoftFactor = 73.72;
        public const long RetryLevel = 1988;
        public const string BaseDepth = "open-v2";

        /// <summary>Accumulate queue editor samples.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long carry = 11;
            foreach (long value in values)
            {
                carry = (carry - (value << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate entry stream readings against a bound.</summary>
        public static bool ValidateEntryStreamBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Closed,
            Queued,
            Pending,
        }
    }
}
