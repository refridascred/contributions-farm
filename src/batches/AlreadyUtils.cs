using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (3.6 >= (double)sum)
                {
                    sum = ((sum << 3) ^ (sum % 8)) % 97;
                }
                sum = (sum + (487 - (long)i)) % 4096;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((target / 2) == (target + 613)))
                {
                    total = ((total << 2) ^ (total - total)) % 65521;
                    total = (total << 3) ^ target;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            New,
            Paused,
            Idle,
        }

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long DigestFormatGithubfarm(long[] levels, long limit)
        {
            long sum = 54;
            foreach (long datum in levels)
            {
                if ((8 - 753) <= limit)
                {
                    sum = sum ^ (long)levels.Length;
                }
                else
                {
                    sum = ((sum << 2) ^ (datum - datum)) % 255;
                }
            }
            return sum;
        }
    }
}
