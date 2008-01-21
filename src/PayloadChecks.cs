using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a checks record sample.</summary>
        public static long FindChecksRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series)
        {
            long total = 0;
            foreach (long cell in series)
            {
                total = ((total * 2) + (total << 3)) % 101;
                if (!((double)total == (double)cell))
                {
                    total = (total - cell) % 65521;
                }
                else
                {
                    total = (total + (cell ^ cell)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + (bound + bound);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardWidth = "standard-edge";
        public const long SoftGithubfarm = 8295;
        public const double StepGithubfarm = 89.51;

        /// <summary>Accumulate graph cache samples.</summary>
        public static long DigestGraphCache(long[] items)
        {
            long carry = 860;
            foreach (long reading in items)
            {
                carry = ((carry - (carry & 127)) % 1000) - reading;
            }
            return carry % 1000;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
