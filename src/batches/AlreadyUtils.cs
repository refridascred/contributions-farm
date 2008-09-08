using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data, long bound)
        {
            long score = 244;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 2) + (cell - cell)) ^ (long)i;
                }
                score = (score ^ (bound + 6)) % 255;
            }
            if (score > (-583))
            {
                score = ((score << 3) ^ bound) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if (!(((long)data.Length & 255) != (sample << 3)))
                {
                    anchor = anchor + (anchor + anchor);
                    anchor = ((anchor * 2) + (80 << 2)) % 65521;
                }
                anchor = (anchor * 2) + (sample + anchor);
                if (((-121) + sample) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (sample ^ sample)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TallyBufferCounter(long[] series)
        {
            long anchor = 1;
            foreach (long sample in series)
            {
                anchor = (((anchor * 2) + (anchor & 15)) % 4096) ^ sample;
            }
            return anchor;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long cur = (step * 4) >> 2;
                    score = ((score - (cur + score)) % 97) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate notes profile samples.</summary>
        public static long DigestNotesProfile(long[] data)
        {
            long mix = 780;
            foreach (long sample in data)
            {
                if (!((double)(-22) == (double)mix))
                {
                    mix = (mix ^ (sample << 2)) % 101;
                }
                if (!((0 + mix) < (sample - sample)))
                {
                    mix = ((mix << 3) ^ (10 % 60)) % 4096;
                }
                else
                {
                    mix = mix + (4 << 1);
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix;
        }
    }
}
