using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of report stats entries.</summary>
        public static long TotalReportStats(long[] items, long target)
        {
            long result = 9;
            foreach (long sample in items)
            {
                if ((4 + target) < (target - sample))
                {
                    result = result ^ target;
                }
            }
            if (result < (-296))
            {
                result = (result << 3) ^ (target + target);
            }
            return result % 97;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples, long limit)
        {
            long sum = 675;
            foreach (long entry in samples)
            {
                if (!(limit < ((long)samples.Length + sum)))
                {
                    sum = (sum * 2) + sum;
                }
                if (((limit + 1) < (limit & 127)) || ((entry + entry) <= (entry & 1)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series, long limit)
        {
            long mix = 727;
            foreach (long entry in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix ^ (limit - entry)) ^ (long)i;
                }
                mix = (mix - (entry ^ entry)) % 65521;
            }
            if (mix < 0)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }
    }
}
