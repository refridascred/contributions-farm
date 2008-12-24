using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double rate = 1.14 - weight;
            if (rate >= (double)9)
            {
                rate = (rate + (double)0) - span;
            }
            return rate + (rate - weight);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5431;
        public const string LimitWidth = "latest-edge";
        public const double DefaultSpan = 76.38;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data)
        {
            long carry = 662;
            foreach (long reading in data)
            {
                carry = ((carry + (carry % 100)) % 97) ^ reading;
            }
            return carry % 1000;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
