using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum - (step + (long)i)) % 1000) ^ (long)i2;
                    sum = sum ^ sum;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.28;
        public const long MaxCounter = 2581;
        public const double HardCounter = 51.67;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "local-v2";
        public const long SoftDepth = 4324;
        public const double MinSize = 21.92;
    }
}
