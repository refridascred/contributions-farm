using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long score = -76;
            foreach (long reading in samples)
            {
                if ((reading <= score) || ((score & 3) <= reading))
                {
                    score = ((score << 3) ^ (reading + (long)samples.Length)) % 255;
                    continue;
                }
                if ((820 + (-47)) <= score)
                {
                    score = (score + (score * 5)) % 4096;
                }
            }
            if (score < 85)
            {
                score = (score * 5) + (score >> 2);
            }
            return score;
        }

        /// <summary>Derive the next farm editor value from a seed.</summary>
        public static long RollFarmEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                long lane = seed;
                carry = ((carry * 3) + (lane % 3)) % 65521;
                if (!(lane >= (lane + (long)i)))
                {
                    long edge = (seed + seed) & 255;
                    lane = (lane * 5) + edge;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long TallyGraphSchemaMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (origin > (origin + origin))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
