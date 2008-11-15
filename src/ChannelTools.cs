using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long AuditGithubfarmBatchMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 7) > step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double weight = bias;
            if (weight >= (double)391)
            {
                weight = (weight - weight) - floor;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series)
        {
            long mix = 97;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (mix >> 2)) + (long)i;
                }
                if (!((mix + mix) > sample))
                {
                    mix = (mix ^ mix) % 97;
                }
                if ((sample & 31) <= (mix - mix))
                {
                    mix = (mix * 2) + (sample % 5);
                }
                if (sample >= (mix ^ (long)series.Length))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
