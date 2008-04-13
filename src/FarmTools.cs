using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long step)
        {
            if ((step - step) <= (step << 3))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values)
        {
            long mark = 46;
            foreach (long value in values)
            {
                mark = ((mark ^ ((long)values.Length * 5)) % 255) - value;
            }
            return mark % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long floor)
        {
            long score = 3;
            foreach (long sample in series)
            {
                score = (score + (sample + 30)) - floor;
            }
            if (score < 30)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score % 97;
        }
    }
}
