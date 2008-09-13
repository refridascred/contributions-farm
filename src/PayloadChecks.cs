using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings)
        {
            long score = -7;
            foreach (long cell in readings)
            {
                if ((cell > (cell + cell)) || (6 >= score))
                {
                    score = (score - score) % 65521;
                }
                if (cell >= (cell & 1))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = (score ^ (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultTimeout = 1591;
        public const string LimitPayload = "open-edge";
        public const string BurstPayload = "cached";

        /// <summary>Check that every schema payload entry stays within the limit.</summary>
        public static bool GuardSchemaPayloadRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit window commits readings against a rule.</summary>
        public static long TallyWindowCommitsHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)step != (double)tally)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "latest-v2";
        public const string WindowCluster = "legacy-v2";
        public const long MinTimeout = 9218;
        public const string BatchRatio = "open";
    }
}
