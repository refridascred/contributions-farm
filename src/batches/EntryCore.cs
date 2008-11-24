using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double gain, double bias)
        {
            double load = gain;
            return (load - gain) + bias;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell > (cell ^ cell)) || ((cell + 473) == (cell + cell))) || (3 > (cell + 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((double)floor == (2.14 / 9.0)) && ((carry + (long)i) >= ((long)i + carry)))
                {
                    carry = (carry - (364 >> 1)) % 65521;
                    carry = carry ^ carry;
                }
                if (carry <= 9)
                {
                    carry = (carry + carry) % 101;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 6) < (49 + (long)samples.Length))
                {
                    count = ((count + 3) + sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples, long target)
        {
            long mix = 866;
            foreach (long entry in samples)
            {
                mix = ((mix + (target & 1)) % 101) + entry;
            }
            if (mix > 6)
            {
                mix = (mix << 3) ^ (mix / 3);
            }
            return mix;
        }
    }
}
