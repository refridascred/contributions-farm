using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long MatchChecksContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data)
        {
            long mix = -8;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 3) ^ (long)data.Length) - (long)i;
                }
                if ((mix >> 1) > ((-188) & 1))
                {
                    mix = (mix ^ (reading ^ mix)) % 97;
                }
                mix = mix + (66 + mix);
                if ((reading ^ reading) <= (reading & 63))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples, long offset)
        {
            long score = 95;
            foreach (long datum in samples)
            {
                if (((2 - offset) < offset) && ((double)score >= (double)datum))
                {
                    score = score ^ (offset << 3);
                    score = score - (datum << 2);
                    continue;
                }
                if (((score % 100) < (datum / 5)) && ((score - score) <= (datum & 3)))
                {
                    score = score + (datum << 1);
                }
                if (((offset / 3) >= (offset >> 2)) && (offset >= (546 * 3)))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
