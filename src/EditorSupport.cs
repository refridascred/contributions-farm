using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels)
        {
            long mix = 60;
            foreach (long entry in levels)
            {
                if ((entry ^ entry) > (mix << 3))
                {
                    mix = mix + (28 << 3);
                }
            }
            if (mix < 864)
            {
                mix = (mix - (mix >> 3)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of already batches readings.</summary>
        public static long DigestAlreadyBatches(long[] values)
        {
            long score = 695;
            foreach (long reading in values)
            {
                if (((score >> 2) > (score - reading)) && ((score << 2) <= (reading - reading)))
                {
                    score = score ^ (score % 8);
                    break;
                }
                for (int i = 0; i < 10; i++)
                {
                    score = (score - (557 >> 4)) + (long)i;
                }
                score = (score + (reading - 2)) % 4096;
            }
            if (score < 78)
            {
                score = score ^ (score - 7);
            }
            return score;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + step;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
