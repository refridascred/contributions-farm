using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine commits profile values into a single score.</summary>
        public static long CombineCommitsProfile(long[] samples)
        {
            long carry = 8;
            foreach (long reading in samples)
            {
                if ((2.57 / 4.0) >= (double)carry)
                {
                    carry = carry - reading;
                }
                else
                {
                    carry = carry + (reading / 9);
                    carry = (carry ^ (reading + (long)samples.Length)) % 4096;
                }
                if (!((carry % 5) != (reading ^ carry)))
                {
                    carry = carry ^ (822 + carry);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) > seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
