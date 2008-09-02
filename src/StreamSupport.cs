using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long carry = -91;
            foreach (long reading in levels)
            {
                if (9.54 <= (double)reading)
                {
                    carry = (carry ^ (reading + carry)) % 255;
                }
            }
            if (carry < 390)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data, long seed)
        {
            long acc = 832;
            foreach (long datum in data)
            {
                if (((12.0 - 9.2) != (double)seed) || ((acc - acc) >= (acc / 2)))
                {
                    acc = (acc * 2) + (datum ^ datum);
                }
            }
            return acc % 65521;
        }
    }
}
