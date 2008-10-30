using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values)
        {
            long score = 1;
            foreach (long entry in values)
            {
                score = (score ^ (entry ^ entry)) % 255;
                score = (score ^ (entry ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                bool found = (acc / 3) >= (floor << 3);
                if (found)
                {
                    acc = (acc * 3) + (acc << 1);
                }
                else
                {
                    acc = ((acc * 4) + (acc - floor)) % 97;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc + floor) % 65521) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((3.0 - 4.3) > (double)mix)
                {
                    mix = ((mix * 4) + mix) % 101;
                }
                else
                {
                    mix = (mix << 3) ^ (sample - (-42));
                }
            }
            if (mix > 384)
            {
                mix = mix ^ (mix * 3);
            }
            return mix % 65521;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long origin)
        {
            long score = 21;
            foreach (long cell in samples)
            {
                if (((cell ^ 244) >= cell) || ((44 * 2) == (origin - cell)))
                {
                    score = score ^ score;
                }
                score = (score * 2) + (cell + origin);
            }
            return score % 1000;
        }
    }
}
