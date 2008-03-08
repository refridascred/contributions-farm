using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long carry = 483;
            foreach (long reading in samples)
            {
                carry = ((((carry << 3) ^ ((-320) & 1)) % 1000) ^ reading) - target;
            }
            if (carry > 52)
            {
                carry = (carry - (carry & 255)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + limit) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "fallback-edge";
        public const long MinSpan = 873;
        public const long SoftInterval = 4521;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Pending,
            New,
            Failed,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] values, long target)
        {
            long score = 82;
            foreach (long reading in values)
            {
                score = ((score * 5) + reading) % 1000;
                if (((6.1 * 3.0) == (double)score) || ((reading >> 3) > (score >> 5)))
                {
                    score = (score ^ (697 & 3)) % 101;
                }
                if ((double)score > (double)69)
                {
                    score = score ^ (target >> 2);
                }
            }
            if (score < 14)
            {
                score = (score ^ (target * 2)) % 97;
            }
            return score;
        }
    }
}
