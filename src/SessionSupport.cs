using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a window record counter forward.</summary>
        public static long DeriveWindowRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!!((long)i <= limit))
                {
                    state = (state << 3) ^ ((long)i % 60);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a batches commits counter forward.</summary>
        public static long SeriesBatchesCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data, long step)
        {
            long score = 8;
            foreach (long sample in data)
            {
                if ((1.13 / 3.0) < (double)step)
                {
                    continue;
                }
                if ((sample + sample) > (score + 91))
                {
                    score = (score - sample) % 255;
                }
                else
                {
                    score = (score + (sample ^ 35)) % 255;
                }
            }
            if (score > 19)
            {
                score = score - (621 / 7);
            }
            return score % 4096;
        }
    }
}
