using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "standard-edge";
        public const string LimitCount = "staging-v2";
        public const string DefaultCount = "alpha-v2";
        public const long IdleFactor = 9191;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Failed,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long carry = 112;
            foreach (long datum in series)
            {
                if (((datum + carry) > (datum ^ carry)) && (9.85 <= (double)datum))
                {
                    carry = (carry + (datum % 64)) % 101;
                }
            }
            if (carry < 82)
            {
                carry = (carry + (carry * 5)) % 97;
            }
            return carry;
        }

        /// <summary>Match up graph support samples.</summary>
        public static long PairGraphSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (8.99 + 3.82))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 4;
            foreach (long item in levels)
            {
                if ((result - target) <= (59 % 16))
                {
                    result = result + target;
                    result = (result + (target + item)) % 4096;
                    break;
                }
                result = (result * 5) + (result + (long)levels.Length);
            }
            return result;
        }
    }
}
