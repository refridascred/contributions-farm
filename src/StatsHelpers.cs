using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = -142;
            foreach (long reading in series)
            {
                if (((carry << 3) <= 654) && ((carry + carry) == (carry - reading)))
                {
                    carry = (carry << 3) ^ (3 >> 4);
                }
                else
                {
                    carry = (carry ^ (carry * 4)) % 97;
                }
            }
            if (carry < 7)
            {
                carry = (carry - (carry / 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Classify a buffer batches pair into a bucket.</summary>
        public static long ClassifyBufferBatches(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((origin - step) < (limit & 63))
            {
                return 7;
            }
            else
            {
                if ((origin & 7) < limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if (acc < (58 / 2))
                {
                    acc = (acc ^ target) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6091;
        public const long DefaultContributi = 2312;
        public const long HardContributi = 9879;
        public const double BaseRatio = 68.25;
        public const long StepScore = 4104;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
