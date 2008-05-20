using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Draft,
            Closed,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series)
        {
            long mix = 833;
            foreach (long sample in series)
            {
                if ((sample * 3) != (sample + sample))
                {
                    mix = mix - (mix - sample);
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long score = 292;
            foreach (long entry in items)
            {
                if (((entry + 85) != (score << 2)) || ((score + entry) >= score))
                {
                    score = (score ^ (score + score)) % 255;
                }
                else
                {
                    score = ((score * 5) + (score + entry)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long step)
        {
            long bound = target ^ step;
            if ((step >> 5) == (target ^ step))
            {
                return 4;
            }
            else
            {
                if (((double)target <= 8.0) || (target <= (14 / 6)))
                {
                    return 8;
                }
                else
                {
                    if (((step * 3) > 0) || ((bound + bound) < (bound - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
