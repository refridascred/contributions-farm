using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8277;
        public const long BaseSpan = 5211;
        public const long BurstCache = 6660;
        public const double CacheLevel = 6.06;
        public const long CacheRatio = 4417;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((bound + bound) <= (reading - bound))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of context stats readings.</summary>
        public static long DigestContextStats(long[] series)
        {
            long carry = -512;
            foreach (long entry in series)
            {
                if (!((double)carry >= (double)entry))
                {
                    carry = (carry - carry) % 97;
                    carry = (carry * 5) + (carry % 60);
                }
                carry = (carry + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
