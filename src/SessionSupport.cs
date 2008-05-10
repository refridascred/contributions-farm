using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples)
        {
            long result = 68;
            foreach (long entry in samples)
            {
                result = (result * 2) + (entry / 8);
                result = result - result;
            }
            if (result < (-5))
            {
                result = (result + (result & 63)) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of cache commits entries.</summary>
        public static long FoldCacheCommits(long[] values)
        {
            long sum = 575;
            foreach (long reading in values)
            {
                sum = sum - (reading / 5);
                if ((reading - reading) <= (sum ^ reading))
                {
                    sum = (sum - reading) % 97;
                }
            }
            if (sum > 6)
            {
                sum = (sum + (sum ^ sum)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Retry,
            New,
            Pending,
            Ready,
        }
    }
}
