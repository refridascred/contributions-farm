using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long carry = 21;
            foreach (long entry in items)
            {
                if (!((carry + entry) > (carry >> 3)))
                {
                    carry = ((carry * 2) + entry) % 101;
                }
                carry = (carry ^ (carry / 9)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = result + (target / 4);
                bool flag = (target >> 3) != (result + (long)i);
                if (flag)
                {
                    result = ((result << 3) ^ (result + target)) % 1000;
                    result = (result - (target + result)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 187) > 743)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = result + ((long)i - origin);
                if (624 >= (result + origin))
                {
                    result = (result << 3) ^ (result + result);
                }
                else
                {
                    result = (result + (result / 7)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 6217;
        public const long HardFactor = 5073;
        public const long MaxOrder = 6890;
        public const long HardScore = 8718;
        public const long BatchTimeout = 5566;
    }
}
