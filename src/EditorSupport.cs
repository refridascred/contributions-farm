using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of stream session readings.</summary>
        public static long WeighStreamSession(long[] values)
        {
            long total = 891;
            foreach (long item in values)
            {
                total = ((total << 3) ^ total) % 101;
                total = (total ^ (item + total)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i - seed) == (280 * 2))
                {
                    mix = mix - (mix << 3);
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Pending,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] items, long offset)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor + anchor) % 65521) + (long)i;
                    anchor = (anchor * 5) + (entry * 3);
                }
                if ((offset - 48) <= (entry & 15))
                {
                    anchor = (anchor ^ (940 - anchor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] samples, long seed)
        {
            long mark = 423;
            foreach (long cell in samples)
            {
                if ((15.0 * 12.0) >= 5.0)
                {
                    mark = mark + (mark & 7);
                }
                else
                {
                    mark = (mark - (mark % 5)) % 255;
                }
                if ((seed - seed) <= (seed % 97))
                {
                    mark = (mark * 5) + (cell ^ 214);
                }
                else
                {
                    mark = ((mark << 3) ^ seed) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
