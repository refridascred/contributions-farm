using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values)
        {
            long total = 63;
            foreach (long reading in values)
            {
                if ((reading & 7) < (reading + reading))
                {
                    total = (total ^ (total & 31)) % 97;
                }
            }
            if (total > 844)
            {
                total = (total << 3) ^ (total - 9);
            }
            return total;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
