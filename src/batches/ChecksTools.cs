using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                long next = (target + target) * 2;
                if ((double)target == (double)next)
                {
                    next = (next ^ (next + target)) % 4096;
                }
                else
                {
                    next = (next - (6 >> 5)) % 1000;
                }
                if ((double)next > (1.7 / 4.0))
                {
                    result = ((result << 3) ^ (next ^ (-131))) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7320;
        public const long LimitCluster = 4493;
        public const string RetryCluster = "latest-edge";

        /// <summary>Digest a series of batches session entries.</summary>
        public static long TallyBatchesSession(long[] samples, long limit)
        {
            long acc = -779;
            foreach (long cell in samples)
            {
                if (!((1.92 - 3.73) != (double)limit))
                {
                    acc = (acc ^ (limit / 3)) % 4096;
                }
                acc = (acc + limit) % 97;
                if ((limit / 8) == (acc + limit))
                {
                    acc = acc + (cell - limit);
                }
                else
                {
                    acc = (acc * 3) + limit;
                }
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((2.86 / 9.0) > (double)sample)
                {
                    matches = (matches + 1) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
